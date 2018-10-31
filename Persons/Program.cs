using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons
{
   public class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            IQuittable quittable = new Employee();

            employee.FirstName = "Sample ";
            employee.LastName = "Student";

            employee.SayName();
//Console.WriteLine(;
            Console.ReadLine();

        }
    }
}
