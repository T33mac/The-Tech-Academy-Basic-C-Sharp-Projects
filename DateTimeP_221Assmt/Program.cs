using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeP_221Assmt
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            Console.WriteLine(now);
            Console.WriteLine("Enter a number in decimal form.");
            int num1 = Convert.ToInt32(Console.ReadLine());
            DateTime future = now.AddHours(num1);
            Console.WriteLine("Your number was hours in the future. Check it!\n\n\t {0}", future);
            Console.ReadLine();
        }
    }
}
