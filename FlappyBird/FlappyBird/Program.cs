using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;

namespace FlappyBird
{
    class Program

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
        struct Bird
        {
            public Point[] b1;
            public Point[] b2;
            public Point[] b3;
            public Point[] b4;
            public Point[] b5;

        }
        Bird SetBird(Bird b)
        {
            b.b1 = new Point[9];
            b.b2 = new Point[8];
            b.b3 = new Point[4];
            b.b4 = new Point[8];
            b.b5 = new Point[7];
            return b;
        }
        static void Print(Point[] p, int x, int y, int pause = 150)
        {
            Console.CursorVisible = false;

            ConsoleColor cl = Console.ForegroundColor;
            foreach (Point el in p)
            {
                Console.SetCursorPosition(el.X + x, el.Y + y);
                Console.Write('*');
            }
            Console.SetCursorPosition(p[p.Length-1].X + x, p[p.Length-1].Y + y);
            Console.Write("@");
            Console.ForegroundColor = Console.BackgroundColor;
            Console.SetCursorPosition(0,0);
            Thread.Sleep(pause);
            foreach (Point el in p)
            {
                Console.SetCursorPosition(el.X + x, el.Y + y);
                Console.Write('*');
            }
            Console.SetCursorPosition(p[p.Length - 1].X + x, p[p.Length - 1].Y + y);
            Console.Write("@");
            Console.ForegroundColor = cl;
            Console.SetCursorPosition(0, 0);

        }
     
        static void SetBird(int x, int y, ref Point[] b1, ref Point[] b2, ref Point[] b3, ref Point[] b4, ref Point[] b5)
        {
            b1[0].X = 0 + x; b1[0].Y = 0 + y;
            b1[1].X = 1 + x; b1[1].Y = 0 + y;
            b1[2].X = 2 + x; b1[2].Y = 1 + y;
            b1[3].X = 3 + x; b1[3].Y = 0 + y;
            b1[4].X = 4 + x; b1[4].Y = 0 + y;
            b1[5].X = 1 + x; b1[5].Y = 2 + y;
            b1[6].X = 2 + x; b1[6].Y = 2 + y;
            b1[7].X = 3 + x; b1[7].Y = 2 + y;
            b1[8].X = 4 + x; b1[8].Y = 2 + y;

            b2[0].X = 0 + x; b2[0].Y = 1 + y; //b2[0].SetXY(0 + x, 1 + y);
            b2[1].X = 1 + x; b2[1].Y = 1 + y;
            b2[2].X = 3 + x; b2[2].Y = 1 + y;
            b2[3].X = 4 + x; b2[3].Y = 1 + y;
            b2[4].X = 1 + x; b2[4].Y = 2 + y;
            b2[5].X = 2 + x; b2[5].Y = 2 + y;
            b2[6].X = 3 + x; b2[6].Y = 2 + y;
            b2[7].X = 4 + x; b2[7].Y = 2 + y;

            b3[0].X = 1 + x; b3[0].Y = 2 + y;
            b3[1].X = 2 + x; b3[1].Y = 2 + y;
            b3[2].X = 3 + x; b3[2].Y = 2 + y;
            b3[3].X = 4 + x; b3[3].Y = 2 + y;

            b4[0].X = 1 + x; b4[0].Y = 2 + y;
            b4[1].X = 2 + x; b4[1].Y = 2 + y;
            b4[2].X = 3 + x; b4[2].Y = 2 + y;
            b4[4].X = 0 + x; b4[4].Y = 3 + y;
            b4[5].X = 1 + x; b4[5].Y = 3 + y;
            b4[6].X = 3 + x; b4[6].Y = 3 + y;
            b4[3].X = 4 + x; b4[3].Y = 3 + y;
            b4[7].X = 4 + x; b4[7].Y = 2 + y;


            b5[0].X = 1 + x; b5[0].Y = 2 + y;
            b5[1].X = 2 + x; b5[1].Y = 2 + y;
            b5[2].X = 3 + x; b5[2].Y = 2 + y;
            b5[4].X = 2 + x; b5[4].Y = 3 + y;
            b5[5].X = 1 + x; b5[5].Y = 4 + y;
            b5[3].X = 3 + x; b5[3].Y = 4 + y;
            b5[6].X = 4 + x; b5[6].Y = 2 + y;
        }
        static void Main(string[] args)
        {
          
            Console.WindowHeight = 40;
            Console.WindowWidth = 100;
            SetBufferSize(WindowWidth, WindowHeight);
            int x = 0, y = 0;
            Point[] b1 = new Point[9];
            Point[] b2 = new Point[8];
            Point[] b3 = new Point[4];
            Point[] b4 = new Point[8];
            Point[] b5 = new Point[7];

            
            SetBird(20, 15, ref b1, ref b2, ref b3, ref b4, ref b5);

            

            for (int i = 0; i < 10; i++)
            {
                
                
                Console.WriteLine("Заготовка Floppy Bird");
                int pf = 1500;
                for (int p = 0; p< 50; p += 2)
                {
                    //Print(b1, p, 0, pf);
                    //Print(b2, p+2, 0, pf);
                    //Print(b3, p+4, 0, pf);
                    //Print(b4, p+6, 0, pf);
                    //Print(b5, p+8, 0, pf);
                    //Print(b4, p+10, 0, pf);
                    //Print(b3, p+12, 0, pf);
                    //Print(b2, p+14, 0, pf);
                    Print(b1, p, 0, pf);
                    Print(b2, p , 0, pf);
                    Print(b3, p , 0, pf);
                    Print(b4, p , 0, pf);
                    Print(b5, p , 0, pf);
                    Print(b4, p , 0, pf);
                    Print(b3, p , 0, pf);
                    Print(b2, p , 0, pf);
                    Console.SetCursorPosition(0, 1);
                    Console.WriteLine("p= {0}", p);
                    Console.SetCursorPosition(0, 0);
                }
          
            }

            Console.ReadKey();
            
        }
    }
}
