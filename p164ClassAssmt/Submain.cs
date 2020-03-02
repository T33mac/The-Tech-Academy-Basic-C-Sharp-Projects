using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p164ClassAssmt
{
    public static class Submain
    {
        public static void AltIntro()
        {
            Dividit n = new Dividit();
            Console.WriteLine("Enter a number.");
            n.NumHalf(Convert.ToInt32(Console.ReadLine()));
            Console.ReadLine();
        }
    }
}
