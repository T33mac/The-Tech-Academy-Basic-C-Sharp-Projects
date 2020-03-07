using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructAssmt
{
    class Program
    {
        static void Main(string[] args)
        {
            Number number = new Number();
            number.Amount = 2255;
            Console.WriteLine("Amount is: " + number.Amount);
            Console.ReadLine();
        }
    }
}
