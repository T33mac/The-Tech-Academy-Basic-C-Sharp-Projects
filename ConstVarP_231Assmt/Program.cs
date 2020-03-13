using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstVarP_231Assmt
{
    class Program
    {
        public static void Main(string[] args)
        {
            const string fname = "Joey";
            var lname = "Rodgers";
            Person person = new Person(fname);
            Console.WriteLine("*With default lname from Constructor chain* \n\"" + person.Fname + " " + person.Lname + "\"");

            Person person1 = new Person(fname, lname);
            Console.WriteLine("\n*With both varibles filled in* \n\"" + person1.Fname + " " + person1.Lname + "\"");

            Console.ReadLine();
        }
    }
}
