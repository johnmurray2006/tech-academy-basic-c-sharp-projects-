using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct1
{
    class Program
    {
        public struct Number
        {
            public decimal a;
            public Number(decimal b1)
            {
                a = b1;
            }
        }
        static void Main(string[] args)

        {

            Number number1;
            number1.a = 10;
            Console.WriteLine(number1.a);

            Console.ReadKey();

        }

    }
}

