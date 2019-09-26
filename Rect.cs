using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Rectclass
     {
        
            private int Length;
            private int Width;

            public Rectclass()
            {
                Length = 1;
                Width = 1;
            }

            public Rectclass(int Length, int Width)
            {
                this.Length = Length;
                this.Width = Width;
            }

            public int GetLength()
            {
                return Length;
            }

            public int SetLength(int Length)
            {
                this.Length = Length;
                return this.Length;
            }

            public int GetWidth()
            {
                return Width;
            }

            public int SetWidth(int Width)
            {
                this.Width = Width;
                return this.Width;
            }

            public int GetPerimeter()
            {
                return (Width * 2) + (Length * 2);
            }

            public int GetArea()
            {
                return Length * Width;
            }
        }
    }




