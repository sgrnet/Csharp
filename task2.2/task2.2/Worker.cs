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
        public int id, stazh;
        public string otdel;
        public string name;
        public Worker()
        {
            this.id = 0;
            this.stazh = 0;
            this.otdel = "Кадры";
            this.name = "Worker"+ " "+otdel;
            Console.WriteLine("Конструктор по умолчанию");
        }
        public Worker(int id, int stazh, string otdel, string name)
        {
            
            this.id = id;
            this.stazh = stazh;
            this.otdel = otdel;
            this.name = name + " " + otdel;
            Console.WriteLine(this.name);
        }
    }
}
