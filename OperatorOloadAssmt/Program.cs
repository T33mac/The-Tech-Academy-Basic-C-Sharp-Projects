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
            List<Employee> lstEmp = new List<Employee>();
            Employee emp = new Employee();
            emp.FirstName = "Sample";
            emp.LastName = "Student";
            emp.Id = 12;
            lstEmp.Add(emp);
            Employee emp1 = new Employee();
            emp1.FirstName = "Smart";
            emp1.LastName = "Guy";
            emp1.Id = 12;
            lstEmp.Add(emp1);
            Employee emp2 = new Employee();
            emp2.FirstName = "Jazzy";
            emp2.LastName = "Jeff";
            emp2.Id = 555;
            lstEmp.Add(emp2);

            foreach (var emps in lstEmp)
            {
                Console.WriteLine(emps.FirstName + " " + emps.LastName + " #" + emps.Id);
            }

            if (emp.Id == emp1.Id)
            {
                Console.WriteLine(emp.Id + " appears more than once in this list!");
            }
            Console.Read();
        }
    }
}
