using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 1;
            var b = 2;
            var c = 3;
            //this will add two variables and multiply by c
            Console.WriteLine(a + b * c);

            Console.WriteLine(b - a + c);

            Console.WriteLine( a + b + c);

            Console.WriteLine( a * b * c);
        }

    }
}
