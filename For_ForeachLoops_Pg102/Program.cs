using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_ForeachLoops_Pg102
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                string[] stringarray = { "john", "lj", "emerald", "alyssa" };
                Console.WriteLine("what would you like to add to this array");
                string useranswer = Console.ReadLine();
                Console.ReadLine();
                Console.WriteLine(useranswer + stringarray[0]);
                Console.ReadLine();
                Console.WriteLine(useranswer + stringarray[1]);
                Console.ReadLine();
                Console.WriteLine(useranswer + stringarray[2]);
                Console.ReadLine();
                Console.WriteLine(useranswer + stringarray[3]);
                Console.ReadLine();
                for (int i = 1; i > 0; i++)

                {

                    if (i < 100)
                    {
                        Console.WriteLine(i);

                    }
                }
                Console.ReadLine();
                int[] skiruns = { 5, 6, 7, 8, 9, 10, 11, 12, 17, };
                for (int j = 0; j < skiruns.Length; j++)
                {
                    if (skiruns[j] > 7)
                    {
                        Console.WriteLine("You rocked out some ski runs yesterday. " + skiruns[j]);

                    }
                }
                Console.ReadLine();
                int[] speedskirun = { 22, 25, 31, 35, 39, 42, 43, };
                for (int k = 0; k < speedskirun.Length; k++)
                {
                    if (speedskirun[k] <= 39)
                    {
                        Console.WriteLine("You need to step up the speed. " + speedskirun[k]);
                    }

                }
                Console.ReadLine();

                List<string> names = new List<string>() { "John", "Pete", "Chance", "Bk" };
                Console.WriteLine("What name do you like the best John, Pete, Chance, Bk");
                string username = Console.ReadLine();
                //username.Contains(username);
                foreach (string name in names)
                {
                    if (username == name)
                    {
                        Console.WriteLine(name);
                    }
                    Console.ReadLine();
                }
                if (username!= "John" && username!= "Pete" && username!= "Chance" &&  username!= "Bk")
                { 

                Console.WriteLine("Please give a name out of the list");
                 }

                Console.ReadLine();

                 List<string> trucks = new List<string>() { "F-150", "Tacoma", "Frontier", "Tacoma", "Silverado" };
                 Console.WriteLine("Pick a truck.");
                string newTruck=(Console.ReadLine());

                 int index = 0;
                 if (!trucks.Contains(newTruck))
                 {
                     Console.WriteLine("This truck does not exist.");
                 }

                 else
                 {
                     for (int j = 0; j < trucks.Count; j++)
                     {
                         index = j;
                         if (newTruck == trucks[j])
                         {
                             Console.WriteLine(trucks[j] + " at index of " + index);
                         }
                     }
                     Console.ReadLine();
                 }
                List<string> skis = new List<string>() { "K-2", "Volki", "Volki" };
                Console.WriteLine("Pick the better ski brand out of  Volki and K-2.");
                string skiBrand = (Console.ReadLine());
                foreach (string ski in skis)

                {
                   // if (skiBrand == ski)
                   // {
                     //   Console.WriteLine(ski);
                   // }
                    if (skis.Contains(ski))
                    {
                        Console.WriteLine("Volki is the duplicated in the list.");
                    }

                }
           Console.ReadLine();
            }

        }

    }
} 






    

