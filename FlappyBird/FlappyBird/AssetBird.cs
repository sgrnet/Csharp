using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace FlappyBird
{
    class AssetBird
    {
        public Point[][] FlyState = new Point[8][];
       

        public AssetBird()
        {
            FlyState[0] = new Point[9];
            FlyState[1] = new Point[8];
            FlyState[2] = new Point[4];
            FlyState[3] = new Point[8];
            FlyState[4] = new Point[7];
            FlyState[5] = new Point[8];
            FlyState[6] = new Point[4];
            FlyState[7] = new Point[8];

            //0
            FlyState[0][0].Offset(0, 0);  
            FlyState[0][1].Offset(1, 0);
            FlyState[0][2].Offset(2, 1);
            FlyState[0][3].Offset(3, 0);
            FlyState[0][4].Offset(4, 0);
            FlyState[0][5].Offset(1, 2);
            FlyState[0][6].Offset(2, 2);
            FlyState[0][7].Offset(3, 2);
            FlyState[0][8].Offset(4, 2);
            //1
            FlyState[1][0].Offset(0, 1);
            FlyState[1][1].Offset(1, 1);
            FlyState[1][2].Offset(3, 1);
            FlyState[1][3].Offset(4, 1);
            FlyState[1][4].Offset(1, 2);
            FlyState[1][5].Offset(2, 2);
            FlyState[1][6].Offset(3, 2);
            FlyState[1][7].Offset(4, 2);
            //2
            FlyState[2][0].Offset(1, 2);
            FlyState[2][1].Offset(2, 2);
            FlyState[2][2].Offset(3, 2);
            FlyState[2][3].Offset(4, 2);
            //3
            FlyState[3][0].Offset(1, 2);// 5=3; 6= 2 ;7=1
            FlyState[3][1].Offset(2, 2);
            FlyState[3][2].Offset(3, 2);
            FlyState[3][3].Offset(0, 3);
            FlyState[3][4].Offset(1, 3);
            FlyState[3][5].Offset(3, 3);
            FlyState[3][6].Offset(4, 3);
            FlyState[3][7].Offset(4, 2);
            //4
            FlyState[4][0].Offset(1, 2);
            FlyState[4][1].Offset(2, 2);
            FlyState[4][2].Offset(3, 2);
            FlyState[4][3].Offset(2, 3);
            FlyState[4][4].Offset(1, 4);
            FlyState[4][5].Offset(3, 4);
            FlyState[4][6].Offset(4, 2);
            //5
            FlyState[5][0].Offset(1, 2);
            FlyState[5][1].Offset(2, 2);
            FlyState[5][2].Offset(3, 2);
            FlyState[5][3].Offset(0, 3);
            FlyState[5][4].Offset(1, 3);
            FlyState[5][5].Offset(3, 3);
            FlyState[5][6].Offset(4, 3);
            FlyState[5][7].Offset(4, 2);
            //6
            FlyState[6][0].Offset(1, 2);
            FlyState[6][1].Offset(2, 2);
            FlyState[6][2].Offset(3, 2);
            FlyState[6][3].Offset(4, 2);
            //7
            FlyState[7][0].Offset(0, 1);
            FlyState[7][1].Offset(1, 1);
            FlyState[7][2].Offset(3, 1);
            FlyState[7][3].Offset(4, 1);
            FlyState[7][4].Offset(1, 2);
            FlyState[7][5].Offset(2, 2);
            FlyState[7][6].Offset(3, 2);
            FlyState[7][7].Offset(4, 2);
        }
        public void DrawAsset(int i)
        {
            foreach(Point p in FlyState[i])
            {
                Console.SetCursorPosition(p.X, p.Y);
                Console.Write("*");
            }
        }
        public void SetPos(Point pos, int numberAsset)
        {
            //
        }
        public void ClearAsset(int i)
        {
            ConsoleColor cl = Console.ForegroundColor;
            Console.ForegroundColor = Console.BackgroundColor;
            //Thread.Sleep(pause);
            foreach (Point p in FlyState[i])
            {
                Console.SetCursorPosition(p.X, p.Y);
                Console.Write("*");
            }
            Console.ForegroundColor = cl;
        }
    }
}
