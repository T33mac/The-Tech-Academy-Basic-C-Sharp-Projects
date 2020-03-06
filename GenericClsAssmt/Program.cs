using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperClassAssmt
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> emp = new Employee<string>();
            emp.Things = new List<string>();         //intantiates the new list from generic class
            emp.FirstName = "Jimmy";
            emp.LastName = "Jammer";
            emp.Id = 12;           
            emp.Things.Add("stapler");
            emp.Things.Add("pants");
            emp.Things.Add("bird");
            emp.SayName();
            Console.WriteLine(emp.FirstName + " " + emp.LastName + " ID #" + emp.Id + " has a " + emp.Things[2] + " in his " + emp.Things[1] + " pocket.");
            Console.Read();
        }
    }
}