using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            Step1 s1 = new Step1();
            s1.Move1(22);
            Console.WriteLine("Pick a decimal number.");
            string userNum2 = Console.ReadLine();
            decimal num2 = Convert.ToDecimal(userNum2);
           s1.Move1(num2);
            Console.WriteLine("Pick a number.");
            string userNum4 = Console.ReadLine();
            int num4 = Convert.ToInt32(userNum4);
            s1.Move1(num4);
        }
    }
}
