using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2._2
{
//    Класс – работник(для системы управления предприятием).
//Примеры свойств: идентификатор, стаж, отдел.Примеры
//методов: Перевод в отдел, Повысить, Получить сводку
    class Worker
    {
        private int stazh;
        private string otdel;
        private string name;
        private readonly int id;
        private string dolzhnost;
        private List<string> otdList;
        private List<string> dlList;
        public Worker()
        {
            Random rnd = new Random();
            this.id = rnd.Next(1, 5000);
            this.stazh = 0;
            this.otdel = "Кадры";
            this.name = "Евгений";
            this.dolzhnost = "Стажер";
            this.otdList =  new List<string>();
            this.dlList = new List<string>();
            //stList.Add(this.otdel);
        }
        public Worker(int id, string name,  string otdel, int stazh, string dolzhnost )
        {
            this.id = id;
            this.stazh = stazh;
            this.otdel = otdel;
            this.name = name;
            this.dolzhnost = dolzhnost;
            this.dlList = new List<string>();
            this.otdList = new List<string>();
            
        }
        public static void  PrintInfo(Worker w)
        {
            Console.WriteLine("Id: " + w.id);
            Console.WriteLine("Имя: " + w.name);
            Console.WriteLine("Отдел: " + w.Otdel);
            Console.WriteLine("Должность: " + w.dolzhnost);
            Console.WriteLine("Стаж: " + w.stazh);
        }
        public bool Perevod(string NewOtdel)
        {
            this.otdList.Add(this.otdel);
            this.stazh++;
            this.otdel = NewOtdel;
            return true;
        }
        public bool Perevod(string NewOtdel, string dolzhnost)
        {
            this.otdList.Add(this.otdel);
            this.dlList.Add(this.dolzhnost);
            this.stazh++;
            this.otdel = NewOtdel;
            this.dolzhnost = dolzhnost;
            return true;
        }
        public void SetStazh(int n)
        {
            this.stazh = n;
        }
        public int GetStazh()
        {
            int n = this.stazh;
            return n;
        }
        public bool AddStazh(int i)
        {
            this.stazh = this.stazh + i;
            return true;
        }
        public static void PrintHist(Worker worker)
        {
            Console.WriteLine("==========================");
            Console.WriteLine(worker.name);
            foreach(string el in worker.otdList)
            {
                Console.WriteLine("Отдел :" + el);
            }
            Console.WriteLine("Сейчас в отделе: " + worker.otdel);
            foreach (string el in worker.dlList)
            {
                Console.WriteLine("Должность :" + el);
            }
            Console.WriteLine("Сейчас: " + worker.dolzhnost);
            Console.WriteLine("==========================");
        }

       
        public string Otdel { get => otdel; set => otdel = value; }
        public string Name { get => name; set => name = value; }
       
    }
}
