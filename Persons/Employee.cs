using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons
{
   public class Employee: Person1
    {
        public int Id { get; set; }
        public new void SayName()
        {
            Console.WriteLine(FirstName + LastName);
            
            Console.ReadLine();
            return;
        }


    }
}
