using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task01._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int[] ar = new int[10];
            for (int i = 0; i < 10; ++i)
            {
                ar[i] = i + r.Next(1, 50);
            }
            

        }
        static int[] DelArray(int[] array, int[] par)
        {
            int[] ResArr = new int[array.Length];
            return ResArr;
        }
    }
}
