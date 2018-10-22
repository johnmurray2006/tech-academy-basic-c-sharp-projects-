using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the age of my daughter?");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed1 = number == 15;
            do
            {
                switch (number)
                {

                    case 12:
                        Console.WriteLine("You guessed 12 years old , that is not correct!");
                        Console.WriteLine("Guess a new age");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 21:
                        Console.WriteLine("You guessed 21 years old, that is not correct!");
                        Console.WriteLine("Guess a new age");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 15:
                        Console.WriteLine("You guessed 15, correct!");
                        isGuessed1 = true;
                        break;


                    default:
                        Console.WriteLine("You are wrong!");
                        Console.WriteLine("Guess a different age?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                }
            }
            while (!isGuessed1);
            Console.ReadLine();







        }
    }
}
