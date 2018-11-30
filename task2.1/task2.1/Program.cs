using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2._1
{
    class Program
    {
        static char[] DelSym(char s, char[] arr) // массив без символа
        {
            int size = arr.Length - CountSymInArr(s, arr);
            char[] resArr = new char[size];
            int i = 0;
            foreach(char n in arr)
            {
                if (s!= n)
                {
                    resArr[i] = n;
                    i++;
                }
            }
            return resArr;
        }
        static bool SymInArr(char i, char[] arr) // есть ли символ в массиве
        {
            foreach(char el in arr)
            {
                if (i == el)
                {
                    return true;
                }
            }
            return false;
        }
        static int CountSymInArr(char i , char[] arr)// соличество символов в массиве
        {
            int count = 0;
            foreach (char el in arr)
            {
                if (i == el)
                {
                    count++;
                }
            }
            return count;
        }
        
        static int CalcString(string s)
        {
            char[] str = new char[s.Length];// преобразуем строку в массив
            for (int i = 0; i < s.Length; i++)
            {
                str[i] = s[i];
                Console.Write(str[i]+ " ");
            }
            Console.WriteLine();
            int[] c = new int[s.Length]; // массив кодов символов строки
            for (int i = 0; i< s.Length; i++)
            {
                c[i] = (int)s[i];
                Console.WriteLine(c[i]);
            }
            char[] n = str ;
            int res = 0;
            do
            {
               res = res + n[0] * CountSymInArr(n[0], n);
               Console.WriteLine("res " + res + " sym " + n[0] + " count " + CountSymInArr(n[0], n) +" kod " + (int)n[0]);
               n = DelSym(n[0], n);
            } while (n.Length > 0);
     
            Console.WriteLine("res " + res);

            return res % 8;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string s = "Пример строки";  
            s = Console.ReadLine();
            Console.WriteLine("res % 8 = " + CalcString(s));
             
        }
    }
}
