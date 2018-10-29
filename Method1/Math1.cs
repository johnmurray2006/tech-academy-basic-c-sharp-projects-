using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method1
{
    public class Math1

    {   public int result { get; set; }
        public int result1 { get; set; }
        public void Hello(int num1, int num2)
          {
            if (num1 *22> 200)
            {
                result = (num1 * 22); 
            }
            else if (num1 *22< 200)
            {
                result = 200;
            }
            Console.WriteLine(result);
            Console.ReadLine();
            Console.WriteLine(num2);
            Console.ReadLine();
        }
    }       
}
