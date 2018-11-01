using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons
{
   public class Program
    {
        public static string Tree { get; private set; }

        static void Main(string[] args)
        {
            //Employee employee = new Employee();
            //Employee employee2 = new Employee();
            //IQuittable quittable = new Employee();
            List<string> Solids = new List<string>() { "ice", "rock" };
            List<int> Temperture = new List<int>() { 32, 450 };
            
            foreach(string Solid in Solids)
            {
                if (Solid != Tree)
                {
                    Console.WriteLine(Solid);
                }
            }
            Console.ReadLine();

            int[] Temp = { 32, 450 };
            for (int k = 0; k < Temperture.Count; k++)
            {
                if (Temp[k] < 500)
                {
                    Console.WriteLine(Temp[k]);
                }
           
        }
            Console.ReadLine();
           

            //employee.FirstName = "Sample ";
            //employee.LastName = "Student";
            //employee.id = 1;
            //employee2.FirstName = "John";
            //employee2.LastName = "Murray";
            //employee2.id = 2;
            //employee.SayName();


            //Console.WriteLine(employee.id==employee2.id);
            //Console.ReadLine();

        }
    }
}
