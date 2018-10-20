using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisionOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a number");
            string yourNumber = Console.ReadLine();
            long yrNumber = Convert.ToInt32(yourNumber);
            long product = yrNumber * 50;
            Console.WriteLine("Your number times 50 is " + product);
            Console.ReadLine();

            Console.WriteLine("Pick a number");
            string yourNumberOne = Console.ReadLine();
            var yrNumberOne = Convert.ToInt32(yourNumberOne);
            var total = yrNumberOne + 25;
            Console.WriteLine("Your number plus twenty-five is " + total);
            Console.ReadLine();

            Console.WriteLine("Pick a number");
            string yourNumberTwo = Console.ReadLine();
            double yrNumberTwo = Convert.ToInt32(yourNumberTwo);
            double quotianted = yrNumberTwo / 12.5;
            Console.WriteLine("Your number divided by twelve and a half is  " + quotianted);
            Console.ReadLine();

            Console.WriteLine("Pick a number");
            string yourNumberThree = Console.ReadLine();
            double yrNumberThree = Convert.ToInt32(yourNumberThree);
            bool isRight = yrNumberThree >= 50;
            Console.WriteLine(isRight);
            Console.ReadLine();

            Console.WriteLine("Pick a number");
            string yourNumberFour = Console.ReadLine();
            int yrNumberFour = Convert.ToInt32(yourNumberFour);
            int quotiantedOne = yrNumberFour / 7;
            Console.WriteLine("Your number divided by seven " + quotiantedOne );
            Console.ReadLine();
            int remainder = (yrNumberFour % 7);
            Console.WriteLine("The remainder is " + remainder);
            Console.ReadLine();



            //int combined = total + otherTotal;
            //Console.WriteLine(" " + total.ToString());
            //Console.ReadLine();




        }
    }
}
