using System;

namespace Tech_Academy_Student
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy.");
            Console.ReadLine();
            Console.WriteLine("Student Daily Report.");
            Console.ReadLine();
            Console.WriteLine("What course are you on?");
            string courseLevel = Console.ReadLine();
            Console.WriteLine("I am on the " + courseLevel + (" course"));
            Console.ReadLine();
            Console.WriteLine("What page number?");
            string  pageNumber = Console.ReadLine();
            Console.WriteLine("I am on page " + pageNumber + (" of the ") + courseLevel+ (" course."));
            Console.ReadLine();
            Console.WriteLine("Do you need help with anything? Please answer true or false.");
            string helpNeeded= Console.ReadLine();
            Console.ReadLine();
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            Console.ReadLine();
            Console.WriteLine("Is there any other feedback you'd like to share? Please be specific.");
            Console.ReadLine();
            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();



        }
    }
}
