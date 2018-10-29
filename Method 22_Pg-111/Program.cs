using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_22_Pg_111
{
   public class Program
    {
        static void Main(string[] args)
        {
            Method_Math math = new Method_Math();
            math.Caller(88, 76);
            math.Caller1(77, 2);
            math.Caller2(66, 7);
           //Method 1
            Console.WriteLine("Pick a number.");
            string userNum1= Console.ReadLine();
            int num1 = Convert.ToInt32(userNum1);
            Console.WriteLine("Pick a number.");
            string userNum2 = Console.ReadLine();
            int num2=Convert.ToInt32(userNum2);
            math.Caller( num1, num2);
            // Method 2
            Console.WriteLine("Pick a number.");
            string userNum3 = Console.ReadLine();
            int num3 = Convert.ToInt32(userNum3);
            Console.WriteLine("Pick a number.");
            string userNum4 = Console.ReadLine();
            int num4 = Convert.ToInt32(userNum4);
            math.Caller1(num3, num4);
            // Method 3
            Console.WriteLine("Pick a number.");
            string userNum5 = Console.ReadLine();
            int num5 = Convert.ToInt32(userNum5);
            Console.WriteLine("Pick a number.");
            string userNum6 = Console.ReadLine();
            int num6 = Convert.ToInt32(userNum6);
            math.Caller2(num5, num6);


        }
    }
}

