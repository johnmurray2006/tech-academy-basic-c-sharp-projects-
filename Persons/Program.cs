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
            Employee employee2 = new Employee();
            IQuittable quittable = new Employee();

            employee.FirstName = "Sample ";
            employee.LastName = "Student";
            employee.id = 1;
            employee2.FirstName = "John";
            employee2.LastName = "Murray";
            employee2.id = 2;
            employee.SayName();


            Console.WriteLine(employee.id==employee2.id);
            Console.ReadLine();

        }
    }
}
