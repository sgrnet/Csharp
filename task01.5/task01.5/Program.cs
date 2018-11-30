using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace task01._5
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo uKb;
            Random rnd = new Random();
            ConsoleKey key;
            int eCount = 0, wCount = 0;
            do
            {
                var kb = Enum.GetValues(typeof(ConsoleKey));

                key = (ConsoleKey)rnd.Next(65, 90);
                Console.WriteLine("Нажми клавишу " + key);
                uKb = Console.ReadKey(true);

                if (uKb.Key == key)
                {
                    Console.WriteLine("Попал " + uKb.Key);
                    wCount++;
                }
                else
                {
                    Console.WriteLine("Ошибка " + uKb.Key);
                    eCount++;
                    wCount = 0;
                }
                if (wCount == 10)
                {
                    //Console.WriteLine("Ты крут");
                    Fkruto();
                    wCount = 0;
                   // Console.ReadKey();
                    continue;
                }
                if (eCount == 3)
                {
                    //Console.WriteLine("Лошара");
                    FLose();
                    eCount = 0;
                    //Console.ReadKey();
                    continue;
                }


            } while ((int)uKb.Key != 27);
        }
        static void FLose()
        {
            Console.Clear();
            int sdvig_x = 5, sdvig_y = 7;
            int cw, ch;
            Random r = new Random();
 
            int[] x = new int[] {

            0,0,0,0,0,0,0,0,0,0,2,4,6,6,6,6,6,6,6,6,6,6,
            15,14,13,12,11,11,11,11,11,11,17,17,17,17,17,17,17,17,17,17,
            24,23,22,22,22,22,22,22,23,24,26,27,28,28,28,28,28,28,27,26,
            33,33,34,35,36,35,34,33,33,33,39,39,38,37,37,38,39,39,39,
            47,46,45,45,45,45,45,45,46,47,49,50,51,51,51,51,51,51,50,49,
                };
            int[] y = new int[] {

            0,1,2,3,4,5,6,7,8,9,0,0,0,1,2,3,4,5,6,7,8,9,
            0,1,2,3,4,5,6,7,8,9,0,1,2,3,4,5,6,7,8,9,
            0,1,2,3,4,5,6,7,8,9,0,1,2,3,4,5,6,7,8,9,
            0,1,2,3,4,5,6,7,8,9,0,1,2,3,5,6,7,8,9,
            0,1,2,3,4,5,6,7,8,9,9,8,7,6,5,4,3,2,1,0,
               };


            
            cw = Console.WindowWidth;
            ch = Console.WindowHeight;
            Console.WindowWidth = 120;
            Console.WindowHeight = 30;
            for (int p = 20; p > 1; p /= 2)
            {
                for (int i = 0; i < x.Length; i++)
                {

                    Console.SetCursorPosition(x[i] + sdvig_x, y[i] + sdvig_y);
                  
                    Console.ForegroundColor = ConsoleColor.White;//         SetColor(r.Next(1, 15));
                    Console.Write("8(");
                    Thread.Sleep(p);
                }
                for (int i = 0; i < x.Length; i++)
                {

                    Console.SetCursorPosition(x[i] + sdvig_x, y[i] + sdvig_y);
                 
                    Console.ForegroundColor = /*ConsoleColor.White; */         SetColor(r.Next(1, 15));
                    Console.Write("(");
                    Thread.Sleep(p);
                }
            }



            Console.SetCursorPosition(1, 1);
           
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WindowWidth = cw;
            Console.WindowHeight = ch;
            Console.Clear();
        }
        static void Fkruto()
        {
            Console.Clear();
            int sdvig_x = 10, sdvig_y = 10;
            Console.WindowWidth = 120;
            Console.WindowHeight = 30;
            Random r = new Random();
        
            
            
            int[] x = new int[] {


                0,0,0,0,0,0,0,0,0,0,6,5,4,3,2,2,3,4,5,6,
                11,11,11,11,11,11,11,11,11,11,13,15,16,16,16,16,15,13,
                21,21,21,21,22,24,26,27,27,27,27,27,27,27,27,27,26,24,22,21,
                32,34,36,38,35,35,35,35,35,35,35,35,35,
                43,43,43,43,43,43,43,43,44,46,48,49,49,49,49,49,49,49,49,44,46,48,
                56,56,56,56,56,56,56,56,56,
                61,61,61,61,61,61,61,61,61,
                66,66,66,66,66,66,66,66,66
                };
            int[] y = new int[] {

                0,1,2,3,4,5,6,7,8,9,0,1,2,3,4,5,6,7,8,9,
                0,1,2,3,4,5,6,7,8,9,0,0,1,2,3,4,5,5,
                0,1,2,3,4,4,4,0,1,2,3,4,5,6,7,8,9,9,9,8,
                0,0,0,0,1,2,3,4,5,6,7,8,9,
                1,2,3,4,5,6,7,8,9,9,9,1,2,3,4,5,6,7,8,0,0,0,
                0,1,2,3,4,5,6,8,9,
                0,1,2,3,4,5,6,8,9,
                0,1,2,3,4,5,6,8,9
                            
               };
            
            for (int p = 20; p > 1; p/=2)
            {
                for (int i = 0; i < x.Length; i++)
                {

                    Console.SetCursorPosition(x[i]+ sdvig_x, y[i]+ sdvig_y);
                    
                    Console.ForegroundColor = ConsoleColor.White;//         SetColor(r.Next(1, 15));
                    Console.Write("8)");
                    Thread.Sleep(p);
                }
                for (int i = 0; i < x.Length; i++)
                {

                    Console.SetCursorPosition(x[i]+ sdvig_x, y[i]+ sdvig_y);
                    Console.ForegroundColor = /*ConsoleColor.White; */         SetColor(r.Next(1, 15));
                    Console.Write("8");
                    Thread.Sleep(p);
                }
            }
            


            Console.SetCursorPosition(1, 1);
            
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            

        }
        /// <summary>
        /// Возвращает цвет в зависимости от входного параметра 0-15
        /// </summary>
        /// <param name="v">Номер цвета</param>
        /// <returns></returns>
        private static ConsoleColor SetColor(int v)
        {
            switch (v)
            {
                case (1): return ConsoleColor.DarkBlue; break;
                case (2): return ConsoleColor.DarkGreen; break;
                case (3): return ConsoleColor.DarkCyan; break;
                case (4): return ConsoleColor.DarkRed; break;
                case (5): return ConsoleColor.DarkMagenta; break;
                case (6): return ConsoleColor.DarkYellow; break;
                case (7): return ConsoleColor.Gray; break;
                case (8): return ConsoleColor.DarkGray; break;
                case (9): return ConsoleColor.Blue; break;
                case (10): return ConsoleColor.Green; break;
                case (11): return ConsoleColor.Cyan; break;
                case (12): return ConsoleColor.Red; break;
                case (13): return ConsoleColor.Magenta; break;
                case (14): return ConsoleColor.Yellow; break;
                case (15): return ConsoleColor.White; break;
                default: return ConsoleColor.Black;

            }

        }
    }
}
