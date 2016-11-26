using System;

namespace TimeBoxOpenSDK.Graphics
{
    public class Writing
    {
        public int X;
        public int Y;
        private Letter[] Text;

        private static Type[] Letters = new[]
        {
            typeof(A),
            typeof(B),
            typeof(C),
            typeof(D),
            typeof(E),
            typeof(F),
            typeof(G),
            typeof(H),
            typeof(I),
            typeof(J),
            typeof(K),
            typeof(L),
            typeof(M),
            typeof(N),
            typeof(O),
            typeof(P),
            typeof(Q),
            typeof(R),
            typeof(S),
            typeof(T),
            typeof(U),
            typeof(V),
            typeof(W),
            typeof(X),
            typeof(Y),
            typeof(Z)
        };

        private static Type[] Numbers = new[]
        {
            typeof(O),
            typeof(One),
            typeof(Two),
            typeof(Three),
            typeof(Four),
            typeof(Five),
            typeof(Six),
            typeof(Seven),
            typeof(Eight),
            typeof(Nine)
        };

        private static Type[] Special = new[]
        {
            typeof(Space),
            typeof(Quote),
            typeof(Exclamation),
            typeof(Question),
            typeof(LeftRedirection),
            typeof(RightRedirection)
        };

        public Writing(string str, Color c, int x, int y)
        {
            X = x;
            Y = y;
            SetText(str, c);
        }

        public void SetText(string str, Color c)
        {
            int count = 0;
            char Comparator;
            Type[] Array;
            Text = new Letter[str.Length];


            str = str.ToUpper();
            foreach (char c1 in str)
            {
                Comparator = (char)0;
                if (FillSpecialCharacters(Text, c, c1, count, " '!?<>"))
                {
                    ++count;
                    continue;
                }
                
                Array = null;

                if (c1 >= '0' && c1 <= '9')
                {
                    Comparator = '0';
                    Array = Numbers;
                }

                if (c1 >= 'A' && c1 <= 'Z')
                {
                    Comparator = 'A';
                    Array = Letters;
                }

                int value = c1 - Comparator;

                if (Array == null || value >= Array.Length)
                {
                    ++count;
                    continue;
                }

                Text[count] = (Letter)Activator.CreateInstance(Array[c1 - Comparator], c);
                ++count;
            }
        }

        private bool FillSpecialCharacters(Letter[] Text, Color color, char actual, int count, string special)
        {
            int index = 0;

            foreach (char c in special)
            {
                if (actual == c)
                {
                    Text[count] = (Letter)Activator.CreateInstance(Special[index], color);
                    return (true);
                }
                ++index;
            }

            return (false);
        }

        public void Draw(ColorBoard board)
        {
            int count = 0;

            foreach (Letter letter in Text)
            {
                if (letter != null)
                {
                    letter.Draw(board, this, count);
                    count += letter.GetSize();
                }
            }
        }

        public int GetTotalSize()
        {
            int count = 0;

            foreach (Letter l in Text)
            {
                if (l != null)
                    count += l.GetSize();
            }

            return (count);
        }

        public bool Scroll()
        {
            --X;
            if (X <= GetTotalSize()*-1)
            {
                X = 12;
                return (true);
            }
            return (false);
        }
    }
}
