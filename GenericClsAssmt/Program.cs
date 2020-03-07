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
            emp.Things = new List<string>() { "stapler", "pants", "bird" }; ;    //intantiates the new list from generic class 
            emp.FirstName = "Jimmy";
            emp.LastName = "Jammers";
            emp.Id = 12;           

            Employee<int> emp1 = new Employee<int>();
            emp1.Things = new List<int>();         //intantiates the new list from generic class
            emp1.FirstName = "Tommy";
            emp1.LastName = "Toaster";
            emp1.Id = 15;
            emp1.Things.Add(12);
            emp1.Things.Add(14);
            emp1.Things.Add(51);

            //Console.WriteLine("\n" + emp.FirstName + " " + emp.LastName + " ID #" + emp.Id + " has a " + emp.Things[2] + 
            //    " in his " + emp.Things[1] + " pocket.");
            //Console.WriteLine("\nNot to be outdone, " + emp1.FirstName + " " + emp1.LastName + 
            //    " ID #" + emp1.Id + " fit " + emp1.Things[1] + " in his " + emp.Things[1] + " pockets.");

            List<string> newList = new List<string>(); 

            foreach (var i in emp.Things) 
            {
                newList.Add(i);
            }
            foreach (var j in emp1.Things)
            {
                newList.Add(Convert.ToString(j));
            }
            foreach (var n in newList)
            {
                Console.WriteLine(n);
            }
            Console.ReadLine();
        }  
    }
}