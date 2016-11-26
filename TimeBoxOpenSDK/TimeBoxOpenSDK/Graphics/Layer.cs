using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeBoxOpenSDK.Graphics
{
    public class Layer
    {
        private int X;
        private int Y;
        private int Width;
        private int Height;
        private Color Color;

        public Layer(int x, int y, int width, int height, Color c)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
            Color = c;
        }

        public void Draw(ColorBoard board)
        {
            int county = Y;

            while (county < Y + Height)
            {
                int countx = X;

                while (countx < X + Width)
                {
                    board.SetPixelColor(countx, county, Color);
                    ++countx;
                }
                ++county;
            }
        }
    }
}
