using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            My m = new My();
            Console.WriteLine(m.SumSum(25, 30));
            My2 k = new My2();
            Console.ReadKey();
        }
    }
    class My2
    {
        public static void Print()
        {
            Console.WriteLine("My2.Print");
        }
    }
}
