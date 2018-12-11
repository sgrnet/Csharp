using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlappyBird
{
    class Bird
    {
        struct Point
        {
            int x, y;

            public void SetXY(int nx, int ny)
            {
                x = nx;
                y = ny;
            }
            // свойство X
            public int X
            {
                get { return x; }
                set { x = value; }
            }

            // свойство Y
            public int Y
            {
                get { return y; }
                set { y = value; }
            }
        }
        Point pos;

        private Point Pos { get => pos; set => pos = value; }

        public Bird()
        {
            Pos.SetXY(0, 0); 
        }
    }
}
