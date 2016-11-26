using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeBoxOpenSDK.Graphics
{
    public abstract class Letter
    {
        protected Color Color;

        protected Letter(Color c)
        {
            Color = c;
        }

        public void Draw(ColorBoard board, Writing writing, int position)
        {
            Trace(board, writing, position);
        }

        public virtual int GetSize()
        {
            return (4);
        }

        public abstract void Trace(ColorBoard board, Writing writing, int diff);
    }

    public class A : Letter
    {
        public A(Color c) : base(c) { }

        public override void Trace(ColorBoard board, Writing writing, int diff)
        {
            board.SetPixelColor(writing.X + diff, writing.Y, Color);
            board.SetPixelColor(writing.X + diff + 1, writing.Y, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 1, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y + 1, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 2, Color);
            board.SetPixelColor(writing.X + diff + 1, writing.Y + 2, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y + 2, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 3, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y + 3, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 4, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y + 4, Color);
        }
    }
    public class B : Letter
    {
        public B(Color c) : base(c) { }

        public override void Trace(ColorBoard board, Writing writing, int diff)
        {
            board.SetPixelColor(writing.X + diff, writing.Y, Color);
            board.SetPixelColor(writing.X + diff + 1, writing.Y, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 1, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y + 1, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 2, Color);
            board.SetPixelColor(writing.X + diff + 1, writing.Y + 2, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 3, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y + 3, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 4, Color);
            board.SetPixelColor(writing.X + diff + 1, writing.Y + 4, Color);
        }
    }
    public class C : Letter
    {
        public C(Color c) : base(c) { }

        public override void Trace(ColorBoard board, Writing writing, int diff)
        {
            board.SetPixelColor(writing.X + diff, writing.Y, Color);
            board.SetPixelColor(writing.X + diff + 1, writing.Y, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 1, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 2, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 3, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 4, Color);
            board.SetPixelColor(writing.X + diff + 1, writing.Y + 4, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y + 4, Color);
        }
    }
    public class D : Letter
    {
        public D(Color c) : base(c) { }

        public override void Trace(ColorBoard board, Writing writing, int diff)
        {
            board.SetPixelColor(writing.X + diff, writing.Y, Color);
            board.SetPixelColor(writing.X + diff + 1, writing.Y, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 1, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y + 1, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 2, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y + 2, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 3, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y + 3, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 4, Color);
            board.SetPixelColor(writing.X + diff + 1, writing.Y + 4, Color);
        }
    }
    public class E : Letter
    {
        public E(Color c) : base(c) { }

        public override void Trace(ColorBoard board, Writing writing, int diff)
        {
            board.SetPixelColor(writing.X + diff, writing.Y, Color);
            board.SetPixelColor(writing.X + diff + 1, writing.Y, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 1, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 2, Color);
            board.SetPixelColor(writing.X + diff + 1, writing.Y + 2, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y + 2, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 3, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 4, Color);
            board.SetPixelColor(writing.X + diff + 1, writing.Y + 4, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y + 4, Color);
        }
    }
    public class F : Letter
    {
        public F(Color c) : base(c) { }

        public override void Trace(ColorBoard board, Writing writing, int diff)
        {
            board.SetPixelColor(writing.X + diff, writing.Y, Color);
            board.SetPixelColor(writing.X + diff + 1, writing.Y, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 1, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 2, Color);
            board.SetPixelColor(writing.X + diff + 1, writing.Y + 2, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y + 2, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 3, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 4, Color);
        }
    }
    public class G : Letter
    {
        public G(Color c) : base(c) { }

        public override void Trace(ColorBoard board, Writing writing, int diff)
        {
            board.SetPixelColor(writing.X + diff + 1, writing.Y, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 1, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 2, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y + 2, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 3, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y + 3, Color);

            board.SetPixelColor(writing.X + diff + 1, writing.Y + 4, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y + 4, Color);
        }
    }
    public class H : Letter
    {
        public H(Color c) : base(c) { }

        public override void Trace(ColorBoard board, Writing writing, int diff)
        {
            board.SetPixelColor(writing.X + diff, writing.Y, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 1, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y + 1, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 2, Color);
            board.SetPixelColor(writing.X + diff + 1, writing.Y + 2, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y + 2, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 3, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y + 3, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 4, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y + 4, Color);
        }
    }
    public class I : Letter
    {
        public I(Color c) : base(c) { }

        public override int GetSize()
        {
            return (3);
        }

        public override void Trace(ColorBoard board, Writing writing, int diff)
        {
            board.SetPixelColor(writing.X + diff, writing.Y, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 1, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 2, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 3, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 4, Color);

        }
    }
    public class J : Letter
    {
        public J(Color c) : base(c) { }

        public override void Trace(ColorBoard board, Writing writing, int diff)
        {
            board.SetPixelColor(writing.X + diff + 2, writing.Y, Color);

            board.SetPixelColor(writing.X + diff + 2, writing.Y + 1, Color);

            board.SetPixelColor(writing.X + diff + 2, writing.Y + 2, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 3, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y + 3, Color);

            board.SetPixelColor(writing.X + diff + 1, writing.Y + 4, Color);

        }
    }
    public class K : Letter
    {
        public K(Color c) : base(c) { }

        public override void Trace(ColorBoard board, Writing writing, int diff)
        {
            board.SetPixelColor(writing.X + diff, writing.Y, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 1, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y + 1, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 2, Color);
            board.SetPixelColor(writing.X + diff + 1, writing.Y + 2, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 3, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y + 3, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 4, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y + 4, Color);

        }
    }
    public class L : Letter
    {
        public L(Color c) : base(c) { }

        public override void Trace(ColorBoard board, Writing writing, int diff)
        {
            board.SetPixelColor(writing.X + diff, writing.Y, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 1, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 2, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 3, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 4, Color);
            board.SetPixelColor(writing.X + diff + 1, writing.Y + 4, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y + 4, Color);

        }
    }
    public class M : Letter
    {
        public M(Color c) : base(c) { }

        public override void Trace(ColorBoard board, Writing writing, int diff)
        {
            board.SetPixelColor(writing.X + diff, writing.Y, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 1, Color);
            board.SetPixelColor(writing.X + diff + 1, writing.Y + 1, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y + 1, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 2, Color);
            board.SetPixelColor(writing.X + diff + 1, writing.Y + 2, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y + 2, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 3, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y + 3, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 4, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y + 4, Color);

        }
    }
    public class N : Letter
    {
        public N(Color c) : base(c) { }

        public override void Trace(ColorBoard board, Writing writing, int diff)
        {
            board.SetPixelColor(writing.X + diff, writing.Y, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 1, Color);
            board.SetPixelColor(writing.X + diff + 1, writing.Y + 1, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y + 1, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 2, Color);
            board.SetPixelColor(writing.X + diff + 1, writing.Y + 2, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y + 2, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 3, Color);
            board.SetPixelColor(writing.X + diff + 1, writing.Y + 3, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y + 3, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 4, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y + 4, Color);

        }
    }
    public class O : Letter
    {
        public O(Color c) : base(c) { }

        public override void Trace(ColorBoard board, Writing writing, int diff)
        {
            board.SetPixelColor(writing.X + diff, writing.Y, Color);
            board.SetPixelColor(writing.X + diff + 1, writing.Y, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 1, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y + 1, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 2, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y + 2, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 3, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y + 3, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 4, Color);
            board.SetPixelColor(writing.X + diff + 1, writing.Y + 4, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y + 4, Color);

        }
    }
    public class P : Letter
    {
        public P(Color c) : base(c) { }

        public override void Trace(ColorBoard board, Writing writing, int diff)
        {
            board.SetPixelColor(writing.X + diff, writing.Y, Color);
            board.SetPixelColor(writing.X + diff + 1, writing.Y, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 1, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y + 1, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 2, Color);
            board.SetPixelColor(writing.X + diff + 1, writing.Y + 2, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y + 2, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 3, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 4, Color);

        }
    }
    public class Q : Letter
    {
        public Q(Color c) : base(c) { }

        public override void Trace(ColorBoard board, Writing writing, int diff)
        {
            board.SetPixelColor(writing.X + diff + 1, writing.Y, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 1, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y + 1, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 2, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y + 2, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 3, Color);
            board.SetPixelColor(writing.X + diff + 1, writing.Y + 3, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y + 3, Color);
            
            board.SetPixelColor(writing.X + diff + 1, writing.Y + 4, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y + 4, Color);

        }
    }
    public class R : Letter
    {
        public R(Color c) : base(c) { }

        public override void Trace(ColorBoard board, Writing writing, int diff)
        {
            board.SetPixelColor(writing.X + diff, writing.Y, Color);
            board.SetPixelColor(writing.X + diff + 1, writing.Y, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 1, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y + 1, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 2, Color);
            board.SetPixelColor(writing.X + diff + 1, writing.Y + 2, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 3, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y + 3, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 4, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y + 4, Color);

        }
    }
    public class S : Letter
    {
        public S(Color c) : base(c) { }

        public override void Trace(ColorBoard board, Writing writing, int diff)
        {
            board.SetPixelColor(writing.X + diff, writing.Y, Color);
            board.SetPixelColor(writing.X + diff + 1, writing.Y, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 1, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 2, Color);
            board.SetPixelColor(writing.X + diff + 1, writing.Y + 2, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y + 2, Color);
            
            board.SetPixelColor(writing.X + diff + 2, writing.Y + 3, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 4, Color);
            board.SetPixelColor(writing.X + diff + 1, writing.Y + 4, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y + 4, Color);

        }
    }
    public class T : Letter
    {
        public T(Color c) : base(c) { }

        public override void Trace(ColorBoard board, Writing writing, int diff)
        {
            board.SetPixelColor(writing.X + diff, writing.Y, Color);
            board.SetPixelColor(writing.X + diff + 1, writing.Y, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y, Color);

            board.SetPixelColor(writing.X + diff + 1, writing.Y + 1, Color);

            board.SetPixelColor(writing.X + diff + 1, writing.Y + 2, Color);
            
            board.SetPixelColor(writing.X + diff + 1, writing.Y + 3, Color);

            board.SetPixelColor(writing.X + diff + 1, writing.Y + 4, Color);

        }
    }
    public class U : Letter
    {
        public U(Color c) : base(c) { }

        public override void Trace(ColorBoard board, Writing writing, int diff)
        {
            board.SetPixelColor(writing.X + diff, writing.Y, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 1, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y + 1, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 2, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y + 2, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 3, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y + 3, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 4, Color);
            board.SetPixelColor(writing.X + diff + 1, writing.Y + 4, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y + 4, Color);

        }
    }
    public class V : Letter
    {
        public V(Color c) : base(c) { }

        public override void Trace(ColorBoard board, Writing writing, int diff)
        {
            board.SetPixelColor(writing.X + diff, writing.Y, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 1, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y + 1, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 2, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y + 2, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 3, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y + 3, Color);

            board.SetPixelColor(writing.X + diff + 1, writing.Y + 4, Color);
        }
    }
    public class W : Letter
    {
        public W(Color c) : base(c) { }

        public override void Trace(ColorBoard board, Writing writing, int diff)
        {
            board.SetPixelColor(writing.X + diff, writing.Y, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 1, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y + 1, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 2, Color);
            board.SetPixelColor(writing.X + diff + 1, writing.Y + 2, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y + 2, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 3, Color);
            board.SetPixelColor(writing.X + diff + 1, writing.Y + 3, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y + 3, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 4, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y + 4, Color);

        }
    }
    public class X : Letter
    {
        public X(Color c) : base(c) { }

        public override void Trace(ColorBoard board, Writing writing, int diff)
        {
            board.SetPixelColor(writing.X + diff, writing.Y, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 1, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y + 1, Color);

            board.SetPixelColor(writing.X + diff + 1, writing.Y + 2, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 3, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y + 3, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 4, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y + 4, Color);

        }
    }
    public class Y : Letter
    {
        public Y(Color c) : base(c) { }

        public override void Trace(ColorBoard board, Writing writing, int diff)
        {
            board.SetPixelColor(writing.X + diff, writing.Y, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 1, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y + 1, Color);

            board.SetPixelColor(writing.X + diff + 1, writing.Y + 2, Color);

            board.SetPixelColor(writing.X + diff + 1, writing.Y + 3, Color);

            board.SetPixelColor(writing.X + diff + 1, writing.Y + 4, Color);

        }
    }
    public class Z : Letter
    {
        public Z(Color c) : base(c) { }

        public override void Trace(ColorBoard board, Writing writing, int diff)
        {
            board.SetPixelColor(writing.X + diff, writing.Y, Color);
            board.SetPixelColor(writing.X + diff + 1, writing.Y, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y, Color);

            board.SetPixelColor(writing.X + diff + 2, writing.Y + 1, Color);

            board.SetPixelColor(writing.X + diff + 1, writing.Y + 2, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 3, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 4, Color);
            board.SetPixelColor(writing.X + diff + 1, writing.Y + 4, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y + 4, Color);

        }
    }
    public class Space : Letter
    {
        public Space(Color c) : base(c) { }

        public override int GetSize()
        {
            return (2);
        }

        public override void Trace(ColorBoard board, Writing writing, int diff) { }
    }
    public class Quote : Letter
    {
        public Quote(Color c) : base(c) { }

        public override int GetSize()
        {
            return (2);
        }

        public override void Trace(ColorBoard board, Writing writing, int diff)
        {
            board.SetPixelColor(writing.X + diff, writing.Y, Color);
            board.SetPixelColor(writing.X + diff, writing.Y + 1, Color);
        }
    }
    public class Exclamation : Letter
    {
        public Exclamation(Color c) : base(c) { }

        public override int GetSize()
        {
            return (2);
        }

        public override void Trace(ColorBoard board, Writing writing, int diff)
        {
            board.SetPixelColor(writing.X + diff, writing.Y, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 1, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 2, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 4, Color); 
        }
    }
    public class Question : Letter
    {
        public Question(Color c) : base(c) { }

        public override void Trace(ColorBoard board, Writing writing, int diff)
        {
            board.SetPixelColor(writing.X + diff, writing.Y, Color);
            board.SetPixelColor(writing.X + diff + 1, writing.Y, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y, Color);

            board.SetPixelColor(writing.X + diff + 2, writing.Y + 1, Color);

            board.SetPixelColor(writing.X + diff + 1, writing.Y + 2, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y + 2, Color);

            board.SetPixelColor(writing.X + diff + 1, writing.Y + 4, Color);
        }
    }
    public class LeftRedirection : Letter
    {
        public LeftRedirection(Color c) : base(c) { }

        public override void Trace(ColorBoard board, Writing writing, int diff)
        {
            board.SetPixelColor(writing.X + diff + 2, writing.Y, Color);

            board.SetPixelColor(writing.X + diff + 1, writing.Y + 1, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 2, Color);

            board.SetPixelColor(writing.X + diff + 1, writing.Y + 3, Color);

            board.SetPixelColor(writing.X + diff + 2, writing.Y + 4, Color);
        }
    }
    public class RightRedirection : Letter
    {
        public RightRedirection(Color c) : base(c) { }

        public override void Trace(ColorBoard board, Writing writing, int diff)
        {
            board.SetPixelColor(writing.X + diff, writing.Y, Color);

            board.SetPixelColor(writing.X + diff + 1, writing.Y + 1, Color);

            board.SetPixelColor(writing.X + diff + 2, writing.Y + 2, Color);

            board.SetPixelColor(writing.X + diff + 1, writing.Y + 3, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 4, Color);
        }
    }
    public class One : Letter
    {
        public One(Color c) : base(c) { }

        public override void Trace(ColorBoard board, Writing writing, int diff)
        {
            board.SetPixelColor(writing.X + diff + 1, writing.Y, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 1, Color);
            board.SetPixelColor(writing.X + diff + 1, writing.Y + 1, Color);

            board.SetPixelColor(writing.X + diff + 1, writing.Y + 2, Color);

            board.SetPixelColor(writing.X + diff + 1, writing.Y + 3, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 4, Color);
            board.SetPixelColor(writing.X + diff + 1, writing.Y + 4, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y + 4, Color);

        }
    }
    public class Two : Letter
    {
        public Two(Color c) : base(c) { }

        public override void Trace(ColorBoard board, Writing writing, int diff)
        {
            board.SetPixelColor(writing.X + diff, writing.Y, Color);
            board.SetPixelColor(writing.X + diff + 1, writing.Y, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y, Color);

            board.SetPixelColor(writing.X + diff + 2, writing.Y + 1, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 2, Color);
            board.SetPixelColor(writing.X + diff + 1, writing.Y + 2, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y + 2, Color);

            board.SetPixelColor(writing.X + diff + 0, writing.Y + 3, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 4, Color);
            board.SetPixelColor(writing.X + diff + 1, writing.Y + 4, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y + 4, Color);

        }
    }
    public class Three : Letter
    {
        public Three(Color c) : base(c) { }

        public override void Trace(ColorBoard board, Writing writing, int diff)
        {
            board.SetPixelColor(writing.X + diff, writing.Y, Color);
            board.SetPixelColor(writing.X + diff + 1, writing.Y, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y, Color);

            board.SetPixelColor(writing.X + diff + 2, writing.Y + 1, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 2, Color);
            board.SetPixelColor(writing.X + diff + 1, writing.Y + 2, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y + 2, Color);

            board.SetPixelColor(writing.X + diff + 2, writing.Y + 3, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 4, Color);
            board.SetPixelColor(writing.X + diff + 1, writing.Y + 4, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y + 4, Color);

        }
    }
    public class Four : Letter
    {
        public Four(Color c) : base(c) { }

        public override void Trace(ColorBoard board, Writing writing, int diff)
        {
            board.SetPixelColor(writing.X + diff, writing.Y, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 1, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y + 1, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 2, Color);
            board.SetPixelColor(writing.X + diff + 1, writing.Y + 2, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y + 2, Color);

            board.SetPixelColor(writing.X + diff + 2, writing.Y + 3, Color);

            board.SetPixelColor(writing.X + diff + 2, writing.Y + 4, Color);

        }
    }
    public class Five : Letter
    {
        public Five(Color c) : base(c) { }

        public override void Trace(ColorBoard board, Writing writing, int diff)
        {
            board.SetPixelColor(writing.X + diff, writing.Y, Color);
            board.SetPixelColor(writing.X + diff + 1, writing.Y, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 1, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 2, Color);
            board.SetPixelColor(writing.X + diff + 1, writing.Y + 2, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y + 2, Color);

            board.SetPixelColor(writing.X + diff + 2, writing.Y + 3, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 4, Color);
            board.SetPixelColor(writing.X + diff + 1, writing.Y + 4, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y + 4, Color);

        }
    }
    public class Six : Letter
    {
        public Six(Color c) : base(c) { }

        public override void Trace(ColorBoard board, Writing writing, int diff)
        {
            board.SetPixelColor(writing.X + diff, writing.Y, Color);
            board.SetPixelColor(writing.X + diff + 1, writing.Y, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 1, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 2, Color);
            board.SetPixelColor(writing.X + diff + 1, writing.Y + 2, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y + 2, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 3, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y + 3, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 4, Color);
            board.SetPixelColor(writing.X + diff + 1, writing.Y + 4, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y + 4, Color);

        }
    }
    public class Seven : Letter
    {
        public Seven(Color c) : base(c) { }

        public override void Trace(ColorBoard board, Writing writing, int diff)
        {
            board.SetPixelColor(writing.X + diff, writing.Y, Color);
            board.SetPixelColor(writing.X + diff + 1, writing.Y, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y, Color);

            board.SetPixelColor(writing.X + diff + 2, writing.Y + 1, Color);

            board.SetPixelColor(writing.X + diff + 2, writing.Y + 2, Color);

            board.SetPixelColor(writing.X + diff + 2, writing.Y + 3, Color);

            board.SetPixelColor(writing.X + diff + 2, writing.Y + 4, Color);
        }
    }
    public class Eight : Letter
    {
        public Eight(Color c) : base(c) { }

        public override void Trace(ColorBoard board, Writing writing, int diff)
        {
            board.SetPixelColor(writing.X + diff, writing.Y, Color);
            board.SetPixelColor(writing.X + diff + 1, writing.Y, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 1, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y + 1, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 2, Color);
            board.SetPixelColor(writing.X + diff + 1, writing.Y + 2, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y + 2, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 3, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y + 3, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 4, Color);
            board.SetPixelColor(writing.X + diff + 1, writing.Y + 4, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y + 4, Color);

        }
    }
    public class Nine : Letter
    {
        public Nine(Color c) : base(c) { }

        public override void Trace(ColorBoard board, Writing writing, int diff)
        {
            board.SetPixelColor(writing.X + diff, writing.Y, Color);
            board.SetPixelColor(writing.X + diff + 1, writing.Y, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 1, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y + 1, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 2, Color);
            board.SetPixelColor(writing.X + diff + 1, writing.Y + 2, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y + 2, Color);

            board.SetPixelColor(writing.X + diff + 2, writing.Y + 3, Color);

            board.SetPixelColor(writing.X + diff, writing.Y + 4, Color);
            board.SetPixelColor(writing.X + diff + 1, writing.Y + 4, Color);
            board.SetPixelColor(writing.X + diff + 2, writing.Y + 4, Color);

        }
    }
}
