using System;
using System.Collections.Generic;
using System.Text;

class Program
    {
        static void Main(string[] args)
        {
        string firstName = "John";
        string middleName = "Bernard";
        string lastName = "Murray";
        Console.WriteLine(firstName + middleName + lastName);
        Console.ReadLine();
        lastName = lastName.ToUpper();
        Console.WriteLine(lastName);
        Console.ReadLine();
        StringBuilder sb= new StringBuilder();
        sb.Append ("John went to the store with some friends to get dinner. ");
        sb.Append ("Most of John's friends call hin Murray. ");
        sb.Append("John does not mind the name Murray , but hates when people spell his name Jon. ");
        sb.Append("The only person that call me Johnny is my wife.");
        Console.WriteLine(sb);
        Console.ReadLine();

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

