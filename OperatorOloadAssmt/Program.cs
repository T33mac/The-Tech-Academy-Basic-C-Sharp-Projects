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

            foreach (var emps in lstEmp)
            {
                Console.WriteLine(emps.FirstName + " " + emps.LastName + " #" + emps.Id);
            }
            Console.Read();
        }
    }
}
