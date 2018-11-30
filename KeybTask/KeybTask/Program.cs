using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeybTask
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
                    Console.WriteLine("Ты крут");
                    wCount = 0;
                    Console.ReadKey();
                    continue;
                }
                if (eCount == 3)
                {
                    Console.WriteLine("Лошара");
                    eCount = 0;
                    Console.ReadKey();
                    continue;
                }


            } while ((int)uKb.Key != 27);
        }
    }
}
