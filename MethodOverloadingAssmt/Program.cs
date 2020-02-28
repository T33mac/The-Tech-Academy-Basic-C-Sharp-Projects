using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloadingAssmt
{
    class Program
    {
        static void Main(string[] args)
        {
            Mathy calc = new Mathy();

            Console.WriteLine("Please enter a whole number in decimal form: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            
            int ans1 = calc.Calculate(num1);
            Console.WriteLine("\nLucky you! You've added fifty-five to your number. It is now: {0}.", ans1);

            Console.WriteLine("\nPlease enter another whole number in decimal form: ");
            decimal num2 = Convert.ToDecimal(Console.ReadLine());

            int ans2 = calc.Calculate(num2);
            Console.WriteLine("\nYour number was divided by Fourteen. It is now: {0} (plus or minus).", ans2);

            Console.WriteLine("\nOkay. Enter a third whole number in decimal form now: ");
            string num3 = Console.ReadLine();

            int ans3 = calc.Calculate(num3);
            Console.WriteLine("\nYou've doubled to your number. It is now : {0}.", ans3);
            Console.ReadLine();
        }
    }
}
