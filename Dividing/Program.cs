using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dividing
{
    class Program
    {
        static void Main(string[] args)
        {
            Good_Life gl = new Good_Life();
            Console.WriteLine("Pick a number.");
            string userNum1 = Console.ReadLine(); 
            int num1 = Convert.ToInt32(userNum1);
            gl.Happy2(num1);
            GoodLife1 gl1 = new GoodLife1();
            Console.WriteLine("Pick a number.");
            string userNum2 = Console.ReadLine();
            int num2= Convert.ToInt32(userNum2);
            Console.WriteLine("After method call, value of a : {0}", num1);
            Console.ReadLine();

            //if (string.IsNullOrEmpty(userNum2))

            //{

            //    gl1.Happy3(out num2);

            //}

            //else

            //{

            //    int Temp = Convert.ToInt32(userNum2);

            //    gl1.Happy3(out num2);

            //}


        }




    }

}
