using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class My
    {
        int a, b;
        public My()
        {
            this.a = 0;
            this.b = 0;
            Console.WriteLine("My.Print");
        }

        public My(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public int SumSum(int x, int y)
        {
            return x + y;
        }

        public override bool Equals(object obj)
        {
            var my = obj as My;
            return my != null &&
                   a == my.a &&
                   b == my.b;
        }

        public override int GetHashCode()
        {
            var hashCode = 2118541809;
            hashCode = hashCode * -1521134295 + a.GetHashCode();
            hashCode = hashCode * -1521134295 + b.GetHashCode();
            return hashCode;
        }
    }
}
