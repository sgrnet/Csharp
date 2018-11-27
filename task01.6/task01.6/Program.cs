using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task01._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int[] ar = new int[10], ar_temp = new int[10], ar_return = new int[10];
            
            for(int i = 0; i < 10; ++i)
            {
                ar[i] = i+r.Next(1,50);

            }
            Array.Copy(ar, ar_temp, ar.Length);
            Array.Sort(ar_temp);
            Array.Reverse(ar_temp);
            Console.WriteLine("Исходный массив");
            foreach( int k in ar)
            {
                Console.Write(k+"  ");
            }
            Console.WriteLine();
            Console.WriteLine("Отсортированный массив");
            foreach (int k in ar_temp)
            {
                Console.Write(k+"  ");
            }
            for (int i = 0; i < 10; ++i)
            {
                ar_return[i] = ar[i] + ar_temp[i];
            }
            Console.WriteLine("\nИтоговый массив");
            foreach (int k in ar_return)
            {
                Console.Write(k + "  ");
            }
            Console.ReadKey();
        }
    }
}
