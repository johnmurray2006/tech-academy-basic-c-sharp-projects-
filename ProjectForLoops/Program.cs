using System;
using System.Collections.Generic;
using System.Linq;

class Program
    {
   

    static void Main(string[] args)
    {
        //string[] stringArray = { "John", "Lj", "Emerald", "Alyssa" };
        //Console.WriteLine("What would you like to add to this array");
        //string userAnswer = Console.ReadLine();
        //Console.ReadLine();
        //Console.WriteLine(userAnswer + stringArray[0]);
        //Console.ReadLine();
        //Console.WriteLine(userAnswer + stringArray[1]);
        //Console.ReadLine();
        //Console.WriteLine(userAnswer + stringArray[2]);
        //Console.ReadLine();
        //Console.WriteLine(userAnswer + stringArray[3]);
        //Console.ReadLine();
        //for (int i = 1; i > 0; i++)

        //{

        //    if (i < 100)
        //    {
        //       Console.WriteLine(i);

        //   }
        //}
        //Console.ReadLine();
        //int[] skiRuns = { 5, 6, 7, 8, 9, 10, 11, 12, 17, };
        //for (int j = 0; j < skiRuns.Length; j++)
        //{
        //    if (skiRuns[j] > 7)
        //    {
        //        Console.WriteLine("You rocked out some runs yesterday. " + skiRuns[j]);

        //    }
        //}
        //    Console.ReadLine();
        //int[] speedSkiRun = { 22, 25, 31, 35, 39, 42, 43, };
        //for (int k=0; k< speedSkiRun.Length; k++)
        //{
        //    if (speedSkiRun[k]<=39)
        //    {
        //        Console.WriteLine("You need to step it up. " + speedSkiRun[k]);
        //     }

        //}
        //Console.ReadLine();

        List<string> names = new List<string>() { "John", "Pete", "Chance", "Bk" };
        Console.WriteLine("What name do you like the best John, Pete, Chance, Bk");
        string userName = Console.ReadLine();
        userName.Contains(userName);
        foreach(string name in names) { 
        if (userName!=names)
        {
                Console.WriteLine("Please give a name out of the list");
            }
    }
        Console.ReadLine();
        foreach (string name in names)
        {
            if (userName == name)
            {
                Console.WriteLine(name);
            }
       
            
            Console.ReadLine();

        }
       
        Console.ReadLine();

        List<string> trucks = new List<string>() { "F-150", "Tacoma", "Frontier", "Tacoma", "Silverado" };
        Console.WriteLine("What truck do you like best.");
        string userTruck = Console.ReadLine();
        foreach (string truck in trucks)
        {
            if (userTruck==)
            {
                Console.WriteLine(truck);
             }
        }
        Console.ReadLine();

    }
}






    

