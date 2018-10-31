using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons
{
    public class Employee : Person1, IQuittable

    {
        // public static Person1 operator (Person1 person1, Employee employee) // the first step to adding an operator overload
        //{
        //  person1.Employee.Add(employee);
        //return person1;

        public void Quit(Employee employee)
        {
            throw new NotImplementedException();
        }


        public new void SayName()
        {
            Console.WriteLine(FirstName + LastName);
            
            Console.ReadLine();
            return;
        }

        


    }
}
