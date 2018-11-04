using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date_Time_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            string formattedDate = DateTime.Now.ToString("dddd, dd, MMMM yyyy HH:mm");
            Console.WriteLine(formattedDate);
            Console.ReadLine();
            Console.WriteLine("Pick a number. It will be that many hours later in the day.");

            int hour = Convert.ToInt32(Console.ReadLine());

            DateTime currentTime = DateTime.Now;

            DateTime hoursLater = currentTime.AddHours(hour);

            Console.WriteLine(string.Format("{0} {1}", currentTime, twoHoursLater));

            Console.ReadLine();


        }
    }
}
