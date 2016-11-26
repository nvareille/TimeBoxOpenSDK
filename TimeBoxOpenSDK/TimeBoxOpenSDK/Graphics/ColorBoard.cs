using System.Collections.Generic;

namespace TimeBoxOpenSDK.Graphics
{
    public class ColorBoard
    {
        public byte[] Board;

        private static Color[] Colors = new Color[] {new Black(), new Red(), new Green(), new Blue(), new White(), new Color(255, 0, 255)};
        
        public ColorBoard()
        {
            Board = new byte[363];
        }

        public void SetPixelColor(int x, int y, Color c)
        {
            if (x < 0 || x > 10 || y < 0 || y > 10)
                return;

            Board[y * 33 + x * 3] = (byte)c.Red;
            Board[y * 33 + x * 3 + 1] = (byte)c.Green;
            Board[y * 33 + x * 3 + 2] = (byte)c.Blue;
        }

        public void DrawLine(string str, int line)
        {
            int count = 0;

            while (count < 11)
            {
                SetPixelColor(count, line, Colors[str[count] - '0']);
                ++count;
            }
        }

        public void SetFillColor(Color c)
        {
            int count = 0;

            while (count < 363)
            {
                Board[count] = (byte) c.Red;
                Board[count + 1] = (byte) c.Green;
                Board[count + 2] = (byte) c.Blue;
                count += 3;
            }
        }

        public void Clear()
        {
            SetFillColor(new Black());
        }
    }
}
