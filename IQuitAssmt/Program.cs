using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssmt
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person emp = new Employee();
            //emp.firstName = "Sample";
            //emp.lastName = "Student";
            //emp.SayName();
            //Console.ReadLine();

            Employee emp = new Employee();
            emp.firstName = "Sample";
            emp.lastName = "Student";
            emp.SayName();
            emp.Quit(emp);          //Calling on the quit function
            Console.ReadLine();
        }
    }
}