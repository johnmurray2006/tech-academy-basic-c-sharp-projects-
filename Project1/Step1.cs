using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class Step1
    {

       
        public int result { get; set; }
       
        public void Move1(int num1)
        {
        
            Console.WriteLine(num1 * 200);
            Console.ReadLine();
        }
        public void Move1(decimal num2)
        {
            
            Console.WriteLine(num2 * 222);
            Console.ReadLine();

        }
        public void Move1(string num3)

        {
            int num4 = Convert.ToInt32(num3);
            Console.WriteLine(num4 * 23);
            Console.ReadLine();

        }


    }
}
