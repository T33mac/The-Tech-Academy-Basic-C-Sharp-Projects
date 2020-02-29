using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethodAssmt
{
    public class Numbers
    {
        public void DoStuff(int num1 = 12, int num2 = 22)
        {
            int math1 = num1 * 15;
            int math2 = num2;
            Console.WriteLine("The first number times fifteen is {0}.", math1);
            Console.WriteLine("The second number is {0}.", math2);
        }

    }
}
