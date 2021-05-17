using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 1;
            var b = 2;
            Console.WriteLine(a > b);
            Console.WriteLine(a == b);
            Console.WriteLine(a != b);
            Console.WriteLine(!(a != b));

            Console.WriteLine("*********");

            var d = 1;
            var e = 2;
            var f = 3;
            Console.WriteLine(f > e && f > d);
            Console.WriteLine(f > e && f == d);
            Console.WriteLine(f > e || f == d);
            Console.WriteLine(!(f > e || f == d));
        }
    }
}
