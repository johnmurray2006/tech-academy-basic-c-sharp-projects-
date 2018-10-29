using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods2
{
    class Program
    {
        static void Main(string[] args)
        {
            Class2 cl2 = new Class2();
            Console.WriteLine();
            Console.WriteLine("Pick a number.");
            string userNum1 = Console.ReadLine();
            int num1 = Convert.ToInt32(userNum1);
            Console.WriteLine("Pick a number.");
            string userNum2 = Console.ReadLine();
            if (string.IsNullOrEmpty(userNum2))
            {
                cl2.Happy1(num1);
            }
            else
            {
                int num2 = Convert.ToInt32(userNum2);
                cl2.Happy1(num1, num2);
            }
        }
    }
}
