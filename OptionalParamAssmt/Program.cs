using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParamAssmt
{
    class Program
    {
        static void Main(string[] args)
        {
            IntMethod calc = new IntMethod();

            Console.WriteLine("Enter a whole number in decimal form, press enter, " +
                "\nthen you have the option to enter a second number. Press \nEnter to pass.");
            int num1 = Convert.ToInt32(Console.ReadLine());
            string taco = Console.ReadLine();

            if (taco.Length == 0)
            {
                int ans1 = calc.DoThis(num1);
                Console.WriteLine("Your number times four is: {0}", ans1);
            }
            
            else
            {
                int num2 = Convert.ToInt32(taco);
                int ans2 = calc.DoThis(num1, num2);
                Console.WriteLine("Your first number times your second number is: {0}", ans2);
            }
            Console.ReadLine();
        }
    }
}
