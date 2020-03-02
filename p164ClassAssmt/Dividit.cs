using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p164ClassAssmt
{
    public class Dividit
    {
        public void NumHalf(int num1 = 20)
        {
            int num2;
            NumPers(out num2);
            int equate = num1 / num2;
            WriteAns(num1, equate);           //calling method
            WriteAns();                       //calling overloaded method
        }

        public void NumPers(out int num2)      //method with output parameters
        {
            num2 = 2; 
        }

        public void WriteAns(int num1, int equate)
        {
            Console.WriteLine("\n{0} divided by two equals {1}", num1, equate);
        }
        public void WriteAns()                  //Overloaded method
        {
            int num2;
            NumPers(out num2);
            Console.WriteLine("\nIt's not your fault. \nAnything you entered would have been divided by {0}", num2);
        }
    }
}