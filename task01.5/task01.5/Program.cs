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
            ConsoleKeyInfo k = new ConsoleKeyInfo();//40-126
            Random r = new Random();
            int uKey, count = 0, eCount = 0 ;

            while (((int)k.KeyChar) != 27)
            {
                uKey = r.Next(40, 126);
                Console.WriteLine("\nНажмите клавишу " + (char)uKey);
                k = Console.ReadKey(true);
                if (uKey == (int)k.KeyChar)
                {
                    count++;
                    Console.WriteLine("Верно " + k.KeyChar + " Правильных нажатий: "+count);
                   
                }
                else
                {
                    Console.WriteLine("Ошибка" + k.KeyChar);
                    eCount++;
                    count = 0;
                }
                if (count == 1)
                {
                    Console.Clear();
                    //Fkruto();

                    Action pohvala = Fkruto;
                    Parallel.Invoke(pohvala/*, pohvala, pohvala*/);
                    count = 0;
                }
                if (eCount == 3)
                {
                    
                    for (int i = 0; i < 15; ++i)
                    {
                        Console.Clear();
                        Console.ForegroundColor = SetColor(r.Next(1,15));
                        Console.SetCursorPosition(49, 10);
                        Console.WriteLine("ТРИ ОШИБКИ!!!  ПОКА!!!");
                        Thread.Sleep(500);
                    }
                  
                    break;
                }
               
            }


          

        }
        static void Fkruto()
        {
            Random r = new Random();
            //Console.ForegroundColor = ConsoleColor.DarkYellow;
            //Console.ForegroundColor = SetColor(r.Next(1, 15));
            
            
            int[] x = new int[] {
                

                14, 14, 14, 14, 14, 14, 14, 14, 14, 14,   20,19,18,17,16,16,17,18,19,20,//K
                25,25,25,25,25,25,25,25,25,25,      27,29,30,30,30,30,29,27,
                35,35,35,35,36,38,40,   41,41,41,41,41,41,41,41,41,40,38,36,35,
                46,48,50,52,    49,49,49,49,49,49,49,49,49,
                57,57,57,57,57,57,57,57,    58,60,62,   63,63,63,63,63,63,63,63, 58,60,62,
                70,70,70,70,70,70,70,70,70,
                75,75,75,75,75,75,75,75,75,
                80,80,80,80,80,80,80,80,80,

                };
            int[] y = new int[] {
               

                8,9,10,11,12,13,14,15,16,17,       8,9,10,11,12,13,14,15,16,17,//К
                8,9,10,11,12,13,14,15,16,17,        8,8,9,10,11,12,13,13,
                8,9,10,11,12,12,12,     8,9,10,11,12,13,14,15,16,17,17,17,16,
                8,8,8,8,    9,10,11,12,13,14,15,16,17,  
                9,10,11,12,13,14,15,16, 17,17,17,   9,10,11,12,13,14,15,16, 8,8,8,
                 8,9,10,11,12,13,14,16, 17,
                8,9,10,11,12,13,14,16, 17,
                8,9,10,11,12,13,14,16, 17,
               };
            
            for (int p = 10; p > 0; --p)
            {
                for (int i = 0; i < x.Length; i++)
                {

                    Console.SetCursorPosition(x[i], y[i]);
                    Console.ForegroundColor = ConsoleColor.White;//         SetColor(r.Next(1, 15));
                    Console.Write("()");
                    Thread.Sleep(p);
                }
                for (int i = 0; i < x.Length; i++)
                {

                    Console.SetCursorPosition(x[i], y[i]);
                    Console.ForegroundColor = /*ConsoleColor.White; */         SetColor(r.Next(1, 15));
                    Console.Write("/");
                    Thread.Sleep(p);
                }
            }
            


            Console.SetCursorPosition(1, 20);
            Console.ReadKey();
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
