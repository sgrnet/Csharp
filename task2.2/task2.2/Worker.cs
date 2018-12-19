using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace task2._2
{
//    Класс – работник(для системы управления предприятием).
//Примеры свойств: идентификатор, стаж, отдел.Примеры
//методов: Перевод в отдел, Повысить, Получить сводку
    struct Pos
    {
        public string Department;
        public string Position;
    }
    class Worker
    {
        private readonly int id;
        private string name;
        private int experience; //стаж
        private string department; //отдел
        private string position; //должность
       
        private List<Pos> posList; // список должностей
        Random r = new Random();
        ~Worker()
        {
            Console.WriteLine("Finalize");
            Console.ReadKey();
        }
        public Worker() : this("Новый работник", "Бухгалтерия")
        {
            this.Position = "Стажер";
        }

        public Worker(string name = "New", string department = "Кадры", string position = "Стажер",  int experience = 0)
        {
            Worker.StatMethod();
            id = r.Next(1, 5000);
            this.Name = name;
            this.Experience = experience;
            this.Department = department;
            this.Position = position;
            posList = new List<Pos>();
        }
        public static void StatMethod()
        {
            Console.WriteLine("Вызов статического метода");
        }
        

        public void PrintCareer()
        {
            WriteLine("Работник: {0} \nТабельный номер: {1} \nСтаж: {2}", Name, Id, Experience);
            foreach(Pos p in PosList)
            {
                WriteLine($"Отдел: {p.Department}, Должность: {p.Position} ");
            }
        }

        public void NewPosition(string department, string position)
        {
            Pos p;
            p.Department = this.Department;
            p.Position = this.Position;
            PosList.Add(p);
            Position = position;
            Department = department;
        }
           
       
        public void AddExpirence(int expierence)
        {
            this.Experience += expierence; 
        }

        public void AddExpirence()
        {
            this.Experience += 1;
        }

        public void PrintStatus()
        {
            WriteLine("Работник: \nID {0}, \nИмя {1}, \nСтаж {2}, \nОтдел {3}, \nДолжность {4} ", Id, Name, Experience, Department, Position);
        }
        public int Id
        {
            get
            {
                return id;
            }
           
        }

        public string Name { get => name; set => name = value; }
        public int Experience { get => experience; set => experience = value; }
        public string Department { get => department; set => department = value; }
        public string Position { get => position; set => position = value; }
        internal List<Pos> PosList { get => posList; set => posList = value; }
    }
}
