using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor1
{
    class Program
    {
        static void Main(string[] args)
        { }
              public class Employee
        {
            const string career = "Intel";
            public string firstName;
            public string lastName;
            public int employeeId;

            public Employee(string f1) : this(f1, "-", 0)
            {
                var firstName = f1;
            }
            public Employee(string f1, string v1) : this(f1, v1, 0)
            {
                firstName = f1;
                lastName = v1;
            }


            public Employee(string f1, string v1, int v2)
            {
                Employee empl = new Employee("John", "Murray", 22);
                var firstName = f1;
                var lastName = v1;
                int employeeId = v2;
             
            }
        }
    }
    }

