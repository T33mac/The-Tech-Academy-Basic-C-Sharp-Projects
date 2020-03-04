using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssmt
{
    public class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            base.SayName();
        }
        public void Quit(Employee employee)
        {
            Console.WriteLine("\nThis employee has quit. Collect all of their belongings and burn them in one of those barrels like in the movies.");
        }
    }
}