using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Expressions_Step140
{
    class Program
    {
        static void Main(string[] args)
        {
            List <Employee1> list= new List<Employee1>();
            list.Add(new Employee1 { firstName = "Joe", lastName = "Mike", employeeId = 1 });
            list.Add(new Employee1 { firstName = "Joe", lastName = "Abbott", employeeId = 2 });
            list.Add(new Employee1 { firstName = "Mike", lastName = "Schocker", employeeId = 3 });
            list.Add(new Employee1 { firstName = "Alyssa", lastName = "Darnall", employeeId = 4 });
            list.Add(new Employee1 { firstName = "Bk", lastName = "Lamp", employeeId = 5 });
            list.Add(new Employee1 { firstName = "Ricky", lastName = "Car", employeeId = 6 });
            list.Add(new Employee1 { firstName = "Mike", lastName = "Mike", employeeId = 7 });
            list.Add(new Employee1 { firstName = "Chance", lastName = "Harrison", employeeId = 8 });
            list.Add(new Employee1 { firstName = "Danny", lastName = "Lopez", employeeId = 9 });
            list.Add(new Employee1 { firstName = "John", lastName = "Murray", employeeId = 10 });
            List<Employee1> joe = new List<Employee1>();

            foreach (Employee1 name in list)

            {
                if (name.firstName == "Joe")
                    {
                    joe.Add(new Employee1 { firstName = name.firstName, lastName = name.lastName, employeeId = name.employeeId });
                    Console.WriteLine(name.firstName + " " + name.lastName + " " + name.employeeId);
                    }
                  Console.ReadLine();
                }
            List<Employee1> joeLambdaEx = list.Where(n => n.firstName == "Joe").ToList();
            foreach (Employee1 name in joeLambdaEx)
            {
                 Console.WriteLine(name.firstName + " " + name.lastName + " " + name.employeeId);
            }
                     Console.ReadLine();
            List<Employee1> greaterThan = list.Where(x => x.employeeId > 5).ToList();
             foreach (Employee1 name in greaterThan)
             {

                Console.WriteLine(name.firstName + " " + name.lastName + " " + name.employeeId);

            }
              Console.ReadLine();




        }
    
    }
}
