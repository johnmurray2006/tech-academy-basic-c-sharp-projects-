using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalaryComparision
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program.");
            Console.ReadLine();
            Console.WriteLine("Person1");
            Console.ReadLine();
            Console.WriteLine("Person1 makes 17 dollars a hour");
            var dolPerHour = 17;
            Console.ReadLine();
            Console.WriteLine("Person1 works thirty-six hours per week.");
            var hoursPerWeek = 36;
            var product = dolPerHour * hoursPerWeek;
            var yearlySalary = product * 52;
            Console.ReadLine();
            Console.WriteLine("Person1 weekly salary is " +  product);
            Console.ReadLine();
            Console.WriteLine("Person1 yearly salary is " + yearlySalary);
            Console.ReadLine();


            Console.WriteLine("Person2");
            Console.ReadLine();
            Console.WriteLine("Person2 makes 19 dollars a hour");
            var dolPerHourA = 19;
            Console.ReadLine();
            Console.WriteLine("Person2 works forty per week.");
            var hoursPerWeekA = 40;
            var productA = dolPerHourA * hoursPerWeekA;
            var yearlySalaryA = productA * 52;
            Console.ReadLine();
            Console.WriteLine("Person2 weekly salary is " + productA);
            Console.ReadLine();
            Console.WriteLine("Person2 yearly salary is " + yearlySalaryA);
            Console.ReadLine();
            Console.WriteLine("Does Person1 make more money than Person2");
            Console.ReadLine();
            Console.WriteLine("False");
            Console.ReadLine();












        }
    }
}
