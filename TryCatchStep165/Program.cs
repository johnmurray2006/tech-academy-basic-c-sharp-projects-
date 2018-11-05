using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchStep165
{
    class Program
    {
        static void Main(string[] args)
        {
            try

            {
                Console.WriteLine("What is your age?");
                int age = Convert.ToInt32(Console.ReadLine());
                if (age <= 0) { throw new FormatException(); }
                if (age > 999999999) { throw new Exception(); }
                int year = 2018 - age;
                Console.WriteLine(year);
                Console.ReadLine();
             }
                catch (FormatException ex)
            {
                Console.WriteLine("Please do not enter zero or negative numbers.");
            }
                catch (Exception ex)

            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }

        }
    }
}
