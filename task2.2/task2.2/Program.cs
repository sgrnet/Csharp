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
           
            Worker Vadim = new Worker("Сидоров Вадим Михайлович", "Транспортный отдел", "Водитель", 4);
            Vadim.NewPosition("Транспортный отдел", "Экспедитор");
            Vadim.NewPosition("Транспортный отдел", "Слесарь по ремонту ТС");
            Vadim.NewPosition("Транспортный отдел", "Начальник смены");
            Vadim.NewPosition("Транспортный отдел", "Зам начальника отдела");
            Vadim.AddExpirence(5);
            Vadim.PrintCareer();
            Console.WriteLine(new string('*', 30));
            Vadim.PrintStatus();
            Console.WriteLine(new string('/', 80));

            Console.WriteLine(new string('*', 30));
            Worker w = new Worker("Сергей Петрович Грибоедов");
            w.NewPosition("Кадры", "Специалист по кадрам");
            w.AddExpirence();
            w.NewPosition("Кадры", "Старший специалист");
            w.AddExpirence();
            w.NewPosition("Кадры", "Начальник отдела");
            w.PrintCareer();
            Console.WriteLine(new string('*', 30));
            w.PrintStatus();
            Console.WriteLine(new string('*', 30));
            Worker b = new Worker();
            b.PrintStatus();
            Console.ReadKey();
        }
    
    }
}
