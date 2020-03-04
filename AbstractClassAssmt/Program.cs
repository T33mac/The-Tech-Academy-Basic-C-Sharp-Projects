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
            Person emp = new Employee();
            emp.firstName = "Sample";
            emp.lastName = "Student";
            emp.SayName();
        }
    }
}
