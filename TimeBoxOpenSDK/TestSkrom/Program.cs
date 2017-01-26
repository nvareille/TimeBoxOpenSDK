using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TimeBoxOpenSDK;
using TimeBoxOpenSDK.Commands;
using TimeBoxOpenSDK.Graphics;

namespace TestSkrom
{
    class Program
    {
        static Thread Job;
        static Thread Eyes;
        static Mutex Mute;
        public static bool OK;
        public static ColorBoard Skrom;
        public static string color;
        public static NetworkStream stream;

        public static void DrawSkrom(bool happy, ColorBoard Skrom, string color)
        {
            SkromDraw.DrawFace(Skrom, color);
            if (!happy)
                SkromDraw.DrawNormalEyes(Skrom, color);
            else
                SkromDraw.DrawHappyEyes(Skrom, color);
        }

        public static void Cligne()
        {
            bool h = false;

            while (!OK) { };

            Thread.Sleep(1000);

            while (true)
            {
                Thread.Sleep(5000);
                Mute.WaitOne();
                DrawSkrom(true, Skrom, color);
                byte[] buff2 = CommandType.SetBoxColor(Skrom.Board);
                stream.Write(buff2, 0, buff2.Length);
                Mute.ReleaseMutex();
                Thread.Sleep(1000);
                Mute.WaitOne();
                DrawSkrom(false, Skrom, color);
                buff2 = CommandType.SetBoxColor(Skrom.Board);
                stream.Write(buff2, 0, buff2.Length);
                Mute.ReleaseMutex();
            }
        }

        public static void Action()
        {
            while (!OK) { }

            stream = TimeBoxWrapper.GetClient().GetStream();
            byte[] buff = CommandType.SetSystemTime();
            color = "1";
            
            stream.Write(buff, 0, buff.Length);
                 
            bool happy = false;
            bool iter = false;
            bool write = false;
            Skrom = new ColorBoard();
            Layer Layer = new Layer(0, 2, 11, 7, new Black());
            Writing w1 = new Writing("Test", new White(), 12, 3);

            while (true)
            {
                DrawSkrom(happy, Skrom, color);

                iter = true;

                while (iter || write)
                {
                    iter = false;

                    if (write)
                    {
                        Layer.Draw(Skrom);
                        w1.Draw(Skrom);
                        write = !w1.Scroll();
                        if (!write)
                            DrawSkrom(happy, Skrom, color);
                    }

                    Thread.Sleep(100);
                    Mute.WaitOne();
                    byte[] buff2 = CommandType.SetBoxColor(Skrom.Board);
                    stream.Write(buff2, 0, buff2.Length);
                    Mute.ReleaseMutex();
                }

                string message = Console.ReadLine();

                if (message.Contains("happy"))
                    happy = true;
                else if (message.Contains("normal"))
                    happy = false;
                else if (message.Contains("blue"))
                    color = "3";
                else if (message.Contains("red"))
                    color = "1";
                else if (message.Contains("green"))
                    color = "2";
                else if (message.Contains("purple"))
                    color = "5";
                else if (message.Contains("gold"))
                    color = "6";
                else
                {
                    write = true;
                    w1.SetText(message, new White());
                }
            }
        }

        static void Main(string[] args)
        {
            TimeBoxWrapper w = new TimeBoxWrapper();
            ColorBoard board = new ColorBoard();
            Job = new Thread(Action);
            Eyes = new Thread(Cligne);
            Mute = new Mutex();
            Job.Start();
            Eyes.Start();

            w.Connect(new AsyncCallback(Connected));
            Job.Join();
        }

        public static void Connected(IAsyncResult r)
        {
            OK = true;
        }
    }
}