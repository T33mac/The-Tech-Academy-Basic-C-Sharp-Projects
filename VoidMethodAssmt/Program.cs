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
            Numbers b = new Numbers();        //instantiate a new class instance
            //b.DoStuff();
            //Console.Read();
            b.DoStuff(num1: 14, num2: 80);    //calling method with new values 
            Console.ReadLine();
        }
    }
}
