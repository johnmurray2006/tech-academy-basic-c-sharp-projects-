using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumStep135
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Console.WriteLine("What day of the week is it?");
                string userDay = Console.ReadLine();
               // int underlying = Convert.ToInt32(DaysofWeek.Thursday);
               // Console.WriteLine(underlying);
                DaysofWeek day = (DaysofWeek)Enum.Parse(typeof(DaysofWeek),userDay, true);
                Console.WriteLine();





            }
            catch (Exception ex)
            {
               
                {
                    Console.WriteLine("Please enter the correct spelling of the day of the week it is.");
                }
              
            }


            {
                Console.ReadLine();
            }
            

        }


    
    }
}
