using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2._2
{
    class Department
    {
        public string Title;
        private Worker[] workers;

        public Department()
        {
            this.Title = "Новый отдел";
        }

        public Department(string title)
        {
            Title = title;
        }
    }
}
