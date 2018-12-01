using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker w = new Worker();
            Worker w2 = new Worker(1,14,"prodazhi", "Petr");
            
           // Console.WriteLine(w.name);
            Console.WriteLine(w2.otdel);
            My();
            Console.ReadKey();
        }
        static void My()
        {
            Worker w2 = new Worker();
        }
    }
}
