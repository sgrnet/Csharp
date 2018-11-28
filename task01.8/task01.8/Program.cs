using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task01._8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] m = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < m.Length; ++i)
            {
                m[i] = rnd.Next(0, 20);
            }
            foreach(int element in m)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine("\nМинимальный элемент  = " + ExpArr(m).min);   //Min(m));
            Console.WriteLine("Максимальный элемент = " + ExpArr(m).max);     //Max(m));
            Console.WriteLine("Среднее = " + ExpArr(m).avg); //Avg(m));
            Console.ReadKey();
        }
        static (int min, int max, float avg) ExpArr(int[] arr)
        {
            (int min, int max, float avg) res = (0, 0, 0);
            res.min = Min(arr);
            res.max = Max(arr);
            res.avg = Avg(arr);
            return res;
        }
        private static int Min(int[] arr)
        {
            int result = arr[0];
            
            for (int i = 0; i< arr.Length; ++i)
            {
                if (arr[i] < result) result = arr[i];
            }
            return result;
        }
        private static int Max(int[] arr)
        {
            int result = arr[0];

            for (int i = 0; i < arr.Length; ++i)
            {
                if (arr[i] > result) result = arr[i];
            }
            return result;
        }
        private static float Avg(int[] arr)
        {
            float sum = 0, count = 0;
            foreach(int el in arr)
            {
                if (el > 0)
                {
                    sum = sum + el;
                    count++;
                }
            }

            return sum / count;
        }
    }
}
