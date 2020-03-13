using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstVarP_231Assmt
{
    public class Person
    {
        public string Fname { get; set; }
        public string Lname { get; set; }
        public Person(string fname): this(fname, "Jones")
        {
            
        }
        public Person(string fname, string lname)
        {
            Fname = fname;
            Lname = lname;
        }
    }
}
