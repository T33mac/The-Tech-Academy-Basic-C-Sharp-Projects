using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethodAssmt
{
    class Program
    {
        static void Main(string[] args)
        {
            Numbers b = new Numbers(); //instantiate a new class instance
            b.DoStuff();               //calling method
            Console.ReadKey();         //this seems to work
        }
    }
}
