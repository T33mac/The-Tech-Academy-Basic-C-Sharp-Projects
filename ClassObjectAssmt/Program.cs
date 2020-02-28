using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObjectAssmt
{
    public class Program
    {
        static void Main(string[] args)
        {
            Calculations calc = new Calculations();
            Console.WriteLine("Please enter a whole number in decimal form: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            int ans1 = calc.Calculate1(num1);  //Parameter must be passed
            int ans2 = calc.Calculate2(num1);
            int ans3 = calc.Calculate3(num1);
            Console.WriteLine("\n\nYour number added to 13 is: " + ans1 + "\n\nYour number multiplied by two is: " + ans2 + "\n\n Your number divided by two is: " + ans3);
            Console.ReadLine();
        }
    }
}
