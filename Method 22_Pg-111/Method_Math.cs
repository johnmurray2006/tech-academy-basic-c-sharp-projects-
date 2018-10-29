using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_22_Pg_111
{
    public class Method_Math
    {
        public int result { get; set; }
        public int result1 { get; set; }
        public int result2 { get; set; }
        public void Caller(int num1, int num2)
        { 
            if (num1 + num2 > 100)
            {
                result = (num1 + num2);
            }
            else if (num1 + num2 < 100)
            {
                result = 100;
                
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
        public void Caller1(int num3, int num4)
        {
            if (num3 * num4 > 100)
            {
                result1 = (num3 * num4);
            }
            else if (num3 * num4 < 100)
            {
                result = 100;
              

            }
            Console.WriteLine(result1);
            Console.ReadLine();
        }
           public void Caller2(int num5, int num6)
        { 
            if (num5 / num6 > 10)
            {
                result2 = (num5 / num6);
            }
            else if (num5 / num6 < 10)
            {
                result2 = 10;

            }
            Console.WriteLine(result2);
            Console.ReadLine();
        }
        
    }
}
   
   

