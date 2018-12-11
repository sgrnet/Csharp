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
            Worker w = new Worker();
            List<Worker> lw;
            lw = new List<Worker>();
            lw.Add(w);
          
            Worker.PrintInfo(w);
            w.Perevod("Закупки");

            w.AddStazh(1);
            //w.PrintInfo();
           
            w.Perevod("Корпоративные продажи");
            w.Perevod("Администрация");
            Worker.PrintHist(w);
            Worker.PrintInfo(w);

            Worker w2 = new Worker(2, "Иван", "Транспортный отдел", 0, "Водитель");
            //Console.WriteLine("stazh " + w.GetStazh());
            Worker.PrintHist(w2); 
            w2.Perevod("Логистика");
            w2.Perevod("Бухгалтерия", "Консультант");
            Console.WriteLine("PrintHist");
            Worker.PrintHist(w);
            w = w2;
            Worker.PrintHist(w);
            Console.ReadKey();
        }
    
    }
}
