using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> empList = new List<Employee>();
            empList.Add(new Employee() { FirstName = "Bob", LastName = "Thomas", Id = 1 });
            empList.Add(new Employee() { FirstName = "Sally", LastName = "Gee", Id = 2 });
            empList.Add(new Employee() { FirstName = "Jim", LastName = "Pikarello", Id = 3 });
            empList.Add(new Employee() { FirstName = "Joe", LastName = "Maphis", Id = 4 });
            empList.Add(new Employee() { FirstName = "Lenny", LastName = "Wallace", Id = 5 });
            empList.Add(new Employee() { FirstName = "Joe", LastName = "Brown", Id = 6 });
            empList.Add(new Employee() { FirstName = "Lonnie", LastName = "Wright", Id = 7 });
            empList.Add(new Employee() { FirstName = "Annie", LastName = "Schultz", Id = 8 });
            empList.Add(new Employee() { FirstName = "Tracy", LastName = "Cottis", Id = 9 });
            empList.Add(new Employee() { FirstName = "Brandon", LastName = "Smith", Id = 10 });

            //-------------ForEach--------------------//
            List<Employee> newList = new List<Employee>();

            foreach (Employee i in empList)
            {
                if (i.FirstName == "Joe")
                {
                    newList.Add(i);
                }
            }

            foreach (Employee i in newList)
            {
                Console.WriteLine("foreach: " + i.FirstName + " " + i.LastName);
            }
            //---------End-ForEach--------------------//

            Console.WriteLine("");

            //---------Same w/Lambda--------------------//
            List<Employee> newList2 = empList.Where(x => x.FirstName == "Joe").ToList();
            foreach (Employee i in newList2)
            {
                Console.WriteLine("Lambda: " + i.FirstName + " " + i.LastName);
            }
            //---------End w/Lambda--------------------//

            Console.WriteLine("");

            //---------Same w/Lambda--------------------//
            List<Employee> newList3 = empList.Where(x => x.Id >= 6).ToList();
            foreach (Employee i in newList3)
            {
                Console.WriteLine("Lambda Id over 5: " + i.FirstName + " " + i.LastName + " Id #" + i.Id);
            }
            Console.ReadLine();
            //---------End w/Lambda--------------------//

        }
    }
}
