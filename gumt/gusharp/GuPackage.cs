using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuPackage
{
    public struct GuPackage
    {

        public static void GuPrint(string Msg)
        {
            Console.WriteLine("By Guyu: " + Msg);
        }

        public struct GuString
        {

            private char[] chars;

            public GuString(char[] chars)
            {
                this.chars = chars;
            }

            public char this[int index]
            {
                get { return chars[index]; }
                set { chars[index] = value; }
            }

            public int Length
            {
                get { return chars.Length; }
            }

            public GuString GuConcat(GuString other)
            {

                char[] newChars = new char[this.Length + other.Length];

                for (int i = 0; i < this.Length; i++)
                {
                    newChars[i] = this[i];
                }

                for (int i = 0; i < other.Length; i++)
                {
                    newChars[this.Length + i] = other[i];
                }

                return new GuString(newChars);
            }

            public override string ToString()
            {
                return new string(chars);
            }

            public string ToGuString()
            {
                return new string(chars);
            }

        }

    }
}
