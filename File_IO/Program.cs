using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace File_IO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a number to be logged into a text file.");
            string text = Console.ReadLine() ;
            File.WriteAllText("C:\\Users\\John Murray\\source\\repos\\fileio.txt", text);
            string fileRead = File.ReadAllText("C:\\Users\\John Murray\\source\\repos\\fileio.txt");
            Console.WriteLine("Number contained in file " + " " + fileRead);
            Console.ReadLine();
        }
    }
}
