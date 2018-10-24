using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "John";
            string middleName = "Bernard";
            string lastName = "Murray";
            Console.WriteLine(firstName +middleName+lastName);
            Console.ReadLine();
            lastName = lastName.ToUpper();
            Console.WriteLine( lastName);
            Console.ReadLine();
            string name = "Jon";
            Console.WriteLine(name + " are you going out tonight");
            Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            sb.Append= sb("My name is John spelled with a H.");


            //string name = "John";
            //string quote = " The man said\"Hello\", John. \n Hello on a new line. \t Hello on a tab.";
            //Console.WriteLine(quote);
            //Console.ReadLine();
            //string fileName = "c\\User\\John";
            ////Or string fileName1 = @"c\User\John";
            //Console.WriteLine(fileName);
            //Console.ReadLine();
            //bool trueOrFalse = name.Contains("J");
            //trueOrFalse = name.EndsWith("n");
            //int length = name.Length;
            //Console.WriteLine(length);
            //name = name.ToUpper();
            //name = name.ToLower();
            //Console.ReadLine();




        }
    }
}
