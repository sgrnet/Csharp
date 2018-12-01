using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KNB

{
    class Program
    {   
        /// <summary>
        /// В зависимости от результата игры выдает цвет
        /// </summary>
        /// <param name="user">Выбор Игрока</param>
        /// <param name="pk">Выбор ПК</param>
        /// <param name="id"> для кого цвет, -1 - Игрок; 1 - ПК</param>
        /// <returns></returns>
        private static ConsoleColor SetColor(int user, int pk, int id)
        {
            int[,] result = new int[3, 3] {
                { 0, 1, -1 }, //{ "Ничья", "ПК", "Игрок" }, 
                { -1, 0, 1 },
                { 1, -1, 0 } };
            if (id == result[user, pk])
            {
                return ConsoleColor.Red;
            }
            else
            {
                return ConsoleColor.White;
            }
        }
        private static string IntToKNB(int i)
        {
            int n = i % 3;
            switch (n)
            {
                case 0: return "Камень";
                    break;
                case 1: return "Ножницы";
                    break;
                case 2: return "Бумага";
                    break;
            }
            return "";
        }
        static string ChekResult(int user, int pk)
        {
            string[,] result = new string[3, 3] { 
                { "Ничья", "ПК", "Игрок" }, 
                { "Игрок", "Ничья", "ПК" }, 
                { "ПК", "Игрок", "Ничья" } };

            return result[user,pk];
        }
        static void Main(string[] args)
        {
            string str;
            int num, pcNum;
            Random rnd = new Random();
            Console.Title = "Камень Ножницы Бумага";
            do
            {
                pcNum = rnd.Next(0,3);
                Console.WriteLine("0-Камень; 1-Ножницы; 2-Бумага");
                str = Console.ReadLine();
                Console.Clear();
                try
                {
                    num = int.Parse(str);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Неперавильный ввод. Ваш выбор - Ножницы");
                    Console.WriteLine();

                    Console.WriteLine("Для выхода введите '-1'" , 500);
                    Console.WriteLine();
                    num = 1;
                }
                num =   Math.Abs(num) % 3;

                Console.ForegroundColor = SetColor(pcNum, num, 1);
                Console.WriteLine("Выбор ПК - " + IntToKNB(pcNum));
                Console.ForegroundColor = SetColor(pcNum, num, -1);
                Console.WriteLine("Выбор Игрока - " + IntToKNB(num));
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Выйграл - " + ChekResult(pcNum, num)); 
            } while (str != "-1");
        }
    }
}
