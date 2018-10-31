using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons
{
    public class Employee : Person1, IQuittable

    { public void Quit(Employee employee)
        {
            throw new NotImplementedException();
        }
       // public static Person1 operator ==(Person1 person1, Employee employee);
        //public static Person1 operator !=(Person1 person1, Employee employee);
        



        public new void SayName()
        {
            Console.WriteLine(FirstName + LastName);
            
            Console.ReadLine();
            return;
            
        }

        


    }
}
