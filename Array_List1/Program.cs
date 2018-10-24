using System;
using System.Collections.Generic;


    class Program
    {
    
        static void Main(string[] args)
        {
            string[] stringArray = { "hope", "love", "caring", "happiness", "excitement" };
            Console.WriteLine("What number out of the array 0-4 would you like to pick?");
            string userString = Console.ReadLine();
            int userNumber = Convert.ToInt32(userString);
            Console.WriteLine(stringArray[userNumber]);
            Console.ReadLine();


            int[] numArray = { 0, 4, 16, 64, 128, 264, 528 };
            Console.WriteLine("Please select an index number of the array.");
            string userInt = Console.ReadLine();
            int userInt1 = Convert.ToInt32(userInt);
            Console.WriteLine(numArray[userInt1]);
            bool numArray1 = userInt1 < 6;
            while (!numArray1)

            {

                switch (userInt1)

                {



                    case 45:

                        Console.WriteLine("You guessed 45, that is not correct!");

                        Console.WriteLine("Gues a lower index number");

                        userInt1 = Convert.ToInt32(Console.ReadLine());

                        break;

                    case 20:

                        Console.WriteLine("You guessed 20, that is not correct!");

                        Console.WriteLine("Guess a lower index number");

                        userInt1 = Convert.ToInt32(Console.ReadLine());

                        break;

                    case 7:

                        Console.WriteLine("You guessed 7, that is not correct!");

                        Console.WriteLine("Guess a lower index number");
                        userInt1 = Convert.ToInt32(Console.ReadLine());

                        break;

                    case 0 - 6:

                        Console.WriteLine("You guessed 39, correct!");
                        userInt1 = Convert.ToInt32(Console.ReadLine());
                        numArray1 = true;

                        break;





                    default:

                        Console.WriteLine("You are wrong!");

                        Console.WriteLine("Guess a new index number?");

                        userInt1 = Convert.ToInt32(Console.ReadLine());

                        break;



                }

            }

            List<string> firstList = new List<String>();
            firstList.Add("Taco Shells");
            firstList.Add("Ground Beef");
            firstList.Add("Tomato");
            firstList.Add("Cheese");
            firstList.Add("Salsa");
            firstList.Add("Onion");
            firstList.Add("Lettuce");
            Console.WriteLine("Please select an index number from the list.");
            string numList = Console.ReadLine();
            int numList1 = Convert.ToInt32(numList);
            Console.WriteLine(firstList[numList1]);
            Console.ReadLine();




        }

    }



    

