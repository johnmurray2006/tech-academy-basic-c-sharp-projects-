using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons
{
    public abstract class Person1
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void SayName()
        {
            Console.WriteLine("Name:[fullname]");
            Console.ReadLine();
            return;
        }
    }
  }


