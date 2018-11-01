using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons
{
    
    public class Employee <T> : Person1 //IQuittable

    {
      public List<T> Things { get; set; } 
        public string Solid { get; set; }
        public int Temperture { get; set; }
     
            
        

        //public void Quit(Employee employee)
        ////{
        ////    throw new NotImplementedException();
        ////}
     
        



        public new void SayName()
        {
            Console.WriteLine(FirstName + LastName);
            
            Console.ReadLine();
            return;
            
        }

        


    }
}
