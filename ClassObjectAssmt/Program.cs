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
            string num1 = Console.ReadLine();
            int line1 = calc.ans1;
            int line2 = calc.ans2;
            int line3 = calc.ans3;
            Console.WriteLine("Your number divided by five is: " + line1 + "\n\nYour number added to 13 is: " + line2 + 
                "\n\nYour number doubled is: " + line3);
            Console.ReadLine();
        }
        public Program(string num1)
        {
            string nummy = num1;
        }
        public string nummy { get; set; }
    }
}
