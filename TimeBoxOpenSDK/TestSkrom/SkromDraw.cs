using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeBoxOpenSDK.Graphics;

namespace TestSkrom
{
    public class SkromDraw
    {
        public static void DrawFace(ColorBoard board, string color)
        {
            board.DrawLine("11110101111".Replace("1", color), 4);
            board.DrawLine("11111111111".Replace("1", color), 5);
            board.DrawLine("01101110110".Replace("1", color), 6);
            board.DrawLine("40111111104".Replace("1", color), 7);
            board.DrawLine("44011111044".Replace("1", color), 8);
            board.DrawLine("44400000444".Replace("1", color), 9);
            board.DrawLine("04444444440".Replace("1", color), 10);
        }

        public static void DrawNormalEyes(ColorBoard board, string color)
        {
            board.DrawLine("10011111001".Replace("1", color), 0);
            board.DrawLine("04401110440".Replace("1", color), 1);
            board.DrawLine("04001110040".Replace("1", color), 2);
            board.DrawLine("10011011001".Replace("1", color), 3);
        }

        public static void DrawHappyEyes(ColorBoard board, string color)
        {
            board.DrawLine("11111111111".Replace("1", color), 0);
            board.DrawLine("10011111001".Replace("1", color), 1);
            board.DrawLine("01101110110".Replace("1", color), 2);
            board.DrawLine("11111011111".Replace("1", color), 3);
        }
    }
}
