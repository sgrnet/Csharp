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
                Console.WriteLine("                   Нажмите клавишу " + (char)uKey);
                k = Console.ReadKey(true);
                if (uKey == (int)k.KeyChar)
                {
                    count++;
                    Console.WriteLine(" Верно   " + k.KeyChar + " count = "+count);
                   
                }
                else
                {
                    Console.WriteLine("Ошибка" + k.KeyChar);
                    eCount++;
                    count = 0;
                }
                if (count == 10)
                {
                    Console.Clear();
                    Fkruto();
                    //Console.WriteLine(" Ты крут "); break;
                    count = 0;
                }
                if (eCount == 3)
                {
                    Console.WriteLine(" КРИВОРУКИЙ!!! "); break;
                }
                //Console.WriteLine((int)k.KeyChar);
            }


            Console.ReadKey();

        }
        static void Fkruto()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            int[] x = new int[] { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 11, 10,
                9, 10, 11, 12, 12, 12, 12,//k

                14, 14, 14, 14, 14, 14, 14, 14, 14, 14,  //Р
                15, 16, 17, 17, 17, 16, 15,

                19, 19, 19, 19, 20, 23, 23, 23, 23, 23,22,22,22,21,21,21,20,20,19,19,//У
                25,26,27,28,29,27,27,27,27,27,27,27,27,27,  //Т
                31,31,31,31,31,31,32,33,34,35,36,36,36,36,36,36,35,34,33,32, //О

                38,39,38,39,38,39,38,39,38,39,38,39,38,39,38,39,38,39,

                };
            int[] y = new int[] { 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 8, 9, 10,
                12, 13, 14, 15, 16, 17,//k

                8, 9, 10, 11, 12, 13, 14, 15, 16, 17,   //Р
                8, 8, 9, 10, 11, 12, 12,

                8, 9, 10, 11, 12, 8, 9, 10, 11, 12, 12,13,14,13,14,15,15,16,16,17, // У
                8,8,8,8,8,9,10,11,12,13,14,15,16,17,  //Т
                10,11,12,13,14,15,16,17,17,16,15,14,13,12,11,10,9,8,8,9, //О

                8,8,9,9,10,10,11,11,12,12,13,13,14,14,16,16,17,17,

               };
            for (int i = 0; i < x.Length; i++)
            {

                Console.SetCursorPosition(x[i], y[i]);
                Console.Write("*");
                Thread.Sleep(100);
            }
            Console.SetCursorPosition(1, 20);
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            

        }
    }
}
