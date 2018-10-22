using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the outside temperture in Durango.");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = number == 39;
            while (!isGuessed)
            {
                switch (number)
                {

                    case 45:
                        Console.WriteLine("You guessed 45 degrees, that is not correct!");
                        Console.WriteLine("Guess a new temperature");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 51:
                        Console.WriteLine("You guessed 51 degrees, that is not correct!");
                        Console.WriteLine("Guess a new temperature");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 39:
                        Console.WriteLine("You guessed 39, correct!");
                        isGuessed = true;
                        break;


                    default:
                        Console.WriteLine("You are wrong!");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                }
            }
            Console.ReadLine();
        }
    }

}

                      

        
        //{
        //    Console.WriteLine("Guess a number?");
        //    int number = Convert.ToInt32(Console.ReadLine());
        //    bool isGuessed = number == 12;
        //    while (!isGuessed)
        //    {
        //        switch (number)
        //        {
        //            case 62:
        //                Console.WriteLine("You guessed 62. Try again");
        //                Console.WriteLine("Guess a number?");
        //                number = Convert.ToInt32(Console.ReadLine());
        //                break;
        //            case 29:
        //                Console.WriteLine("You guessed 29. Try again");
        //                Console.WriteLine("Guess a number?");
        //                number = Convert.ToInt32(Console.ReadLine());
        //                break;
        //            case 12:
        //                Console.WriteLine("You guessed 12, correct");
        //                isGuessed = true;
                       
        //                break;
        //            default:
        //                Console.WriteLine("You are wrong!");
        //                Console.WriteLine("Guess a number?");
        //                number = Convert.ToInt32(Console.ReadLine());
        //                break;
        //        }
        //    }
        //            Console.ReadLine();
       






        
    

