using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(true && false);This is the and operator
            //Console.ReadLine();
            //Console.WriteLine(true || false); This is the or operator
            //Console.WriteLine(true == false); Equals operator
            //Console.WriteLine(true != false); Does not equal
            // Console.WriteLine(true ^ false) This is the x or operator
            Console.WriteLine("We have a few quetions for you to answer to see if Acme Insurance can offer you car insurance. ");
            Console.ReadLine();
            Console.WriteLine("What is your age");
            string yourAge = Console.ReadLine();
            int yrAge = Convert.ToInt32(yourAge);
            Console.ReadLine();
            Console.WriteLine("Have you ever had a DUI before? Answering true means no DUI's(true or false)");
            string yourDui= Console.ReadLine();
            bool a = yourDui == "true";
            bool b = yourDui == "false";
            
              
   
            Console.WriteLine("How many speeding tickets do you have.");
            string yourSpeeding = Console.ReadLine();
            int yrSpeeding= Convert.ToInt32(yourSpeeding);
            bool ageDriver = (yrAge >= 15);
            bool ticketsDriver = (yrSpeeding < 3);
            bool yrDui = (a || b);
            Console.WriteLine("Quilified for our great car insurance.");


            Console.WriteLine(ageDriver && yrDui && ticketsDriver);


            Console.ReadLine();
           









        }
    }
}
