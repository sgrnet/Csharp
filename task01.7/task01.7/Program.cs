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
            int[] ar = new int[30];

            Console.WriteLine("Исходный массив");
            for (int i = 0; i < ar.Length; ++i)
            {
                ar[i] = r.Next(0, 30);
                Console.Write(ar[i] + " ");
            }
            Console.WriteLine("\nпараметры: 8,15,6,23,5,10,12,25,14,3,7,0");

            Console.WriteLine("Результирующий массив");
            
            foreach(int n in DelArray(ar, 8, 15, 6, 23,5,10,12,25,14,3,7,0))
            Console.Write(n + " ");

            Console.ReadKey();
        }
        /// <summary>
        /// Метод удаляет из массива array все элементы совпадающие с параметрами par
        /// </summary>
        /// <param name="array">Исходный массив int</param>
        /// <param name="par">Список параметров пример 2, 4 ,8</param>
        /// <returns>Массив int</returns>
        static int[] DelArray(int[] array, params int[] par)
        {
            if (par.Length > 0)     // если количество параметров больше 0
            {
                int count = array.Length;       // счетчик количества совпадений элементов массива с параметрами
                bool[] chArr = new bool[count]; // массив для записи положения совпадений
                for (int i = 0; i < array.Length; ++i)
                {
                    chArr[i] = true;
                    foreach (int el in par)
                    {
                        if (array[i] == el)
                        {
                            chArr[i] = false;
                            count--;
                        }
                    }
                }
                int[] resArr = new int[count]; // создаем результирующий массив с количеством членов в соответствии со счетчиком совпадений
                for (int i = 0; i < array.Length; ++i)// заполняем результирующий массив
                {
                    if (chArr[i])
                    {
                        resArr[resArr.Length - count] = array[i];
                        count--;
                    }
                }
                return resArr;
            }
            else return null;
        }
    }
}
