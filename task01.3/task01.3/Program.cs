using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task01._3
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = 0, tochnost = 0.000001;
            double en=1, sum=0;
            Console.WriteLine("Первый ряд Е(1/n!)");
            while(en > tochnost)
            {
                en = 1 / Factorial(n);
                sum = sum + en;
                Console.WriteLine("n = " + n + " Сумма ряда = " + sum);
                n++;
            }

            sum = 0;n = 0; tochnost = 0.00001; en = 1;
            Console.WriteLine("Первый ряд");
            while (Math.Abs(en) > tochnost)
            {
                
                en = 4 * ((Math.Pow(-1, n) )/(2 * n + 1));
                sum = sum + en;
                //Console.WriteLine("en = " +en);
                Console.WriteLine("n = " + n + " Сумма ряда = " + sum);

                n++;
            }
            //Console.WriteLine("n = " + n + " Сумма ряда = " + sum);
            Console.ReadKey();
        }
        static double Factorial(double x)
        {
            return (x == 0) ? 1 : x * Factorial(x - 1);
        }
    }
}
