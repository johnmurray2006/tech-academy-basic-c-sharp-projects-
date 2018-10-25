using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Else.IfStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //int currentTemperture = 72;
            //int roomTemperture = 69;
            //string comparisionResult = currentTemperture == roomTemperture ? "It is room temp." : "It is not room temp";
            //Console.WriteLine(comparisionResult);
            //Console.ReadLine(); This called the Turner operator, also just a compact else/if statement.
            //    If the comparision is true then the first statement prints and if false the second statement prints.
            //int roomTemperature = 70;

            //Console.WriteLine("What is yor name?");
            //string name = Console.ReadLine();
            //Console.WriteLine("Hi " +name+ " What is the temperature where you are?");
            //int currentTemperature = Convert.ToInt32(Console.ReadLine());

            //if (currentTemperature == roomTemperature)
            //{
            //    Console.WriteLine("It is exactly the same temp!");
            //}
            //else if (currentTemperature > roomTemperature) 
            //{ Console.WriteLine("It is warmer than room temperature.");
            //}
            //else if (roomTemperature> currentTemperature)
            //{ Console.WriteLine("It is colder than room temperature!");
            //}
            //Console.ReadLine();
            // Console.WriteLine("What is your favorite number?");
            //int favNum = Convert.ToInt32(Console.ReadLine());
            //string result = favNum == 12 ? "You have an awesome favorite number!" : "You do not have an awesome favorite number!";
            //Console.WriteLine(result);
            //Console.ReadLine();


            Console.WriteLine("Welcome to Package Express, please follow the instructions below.");
            Console.ReadLine();
            Console.WriteLine("What is the weight of your package?");
            int packageWeight = Convert.ToInt32(Console.ReadLine());
            if (packageWeight > 50)
            {
                Console.WriteLine("Your package is to heavy to ship with Package Express, have a nice day. You can continue answering Package express shipping questionare.");
            }
            Console.ReadLine();

            Console.ReadLine();
            Console.WriteLine("Please enter the packages width.");
            int packageWidth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the packages length.");
            int packageLength = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the packages height.");
            var packageHeight = Convert.ToInt32(Console.ReadLine());
            decimal Total = packageWidth + packageLength + packageHeight;
            Console.WriteLine(Total);
            if (Total > 50) {
                Console.WriteLine(" Your package dimensions are too big to ship with Package Express thank you and have a nice day."); }
            Console.ReadLine();
            decimal Total1 = Total * packageWeight / 100;
            Console.WriteLine("Your estimated shipping cost is: $" +Total1);
            Console.ReadLine();
        }
    }
}
