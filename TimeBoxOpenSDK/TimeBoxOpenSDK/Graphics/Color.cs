using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeBoxOpenSDK
{
    public class Color
    {
        public int Red;
        public int Green;
        public int Blue;

        public Color(int r, int g, int b)
        {
            Red = r;
            Green = g;
            Blue = b;
        }
    }

    public class Red : Color
    {
        public Red() : base(255, 0, 0)
        {
        }
    }

    public class Green : Color
    {
        public Green() : base(0, 255, 0)
        {
        }
    }

    public class Blue : Color
    {
        public Blue() : base(0, 0, 255)
        {
        }
    }

    public class White : Color
    {
        public White() : base(255, 255, 255)
        {
        }
    }

    public class Black : Color
    {
        public Black() : base(0, 0, 0)
        {
        }
    }
}
