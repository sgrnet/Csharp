using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace task01._4
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "C#";
            int max_x = Console.WindowWidth, max_y = Console.WindowHeight, max_color = 15;
            Random r = new Random();
            
            for (int i = 0; i<300; ++i)
            {
                Console.ForegroundColor = SetColor(r.Next(1, max_color));
                Console.SetCursorPosition(r.Next(1, Console.WindowWidth), r.Next(1, Console.WindowHeight));
                Console.Write(str + i);
                Thread.Sleep(50);
            }
            Console.ReadKey();
        }
        /// <summary>
        /// Возвращает цвет в зависимости от входного параметра 0-15
        /// </summary>
        /// <param name="v">Номер цвета</param>
        /// <returns></returns>
        private static ConsoleColor SetColor(int v)
        {
            switch(v)
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
