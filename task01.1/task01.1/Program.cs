using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task01._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string uStr, str = "Я буду усердно делать все задания по C# и заниматься дома";
            uStr = Console.ReadLine();
            if (uStr == str)
            {
                Console.WriteLine("получишь печеньку");
            }
            Console.ReadKey();

        }
    }
}
