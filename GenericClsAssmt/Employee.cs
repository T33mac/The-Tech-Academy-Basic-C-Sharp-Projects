using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperClassAssmt
{
    public class Employee<T> : Person    //<T> allow the employee class to take a generic parameter video p.185
    {
        public void IdNum()
        {
            throw new NotImplementedException();
        }
        public int Id { get; set; }
        public List<T> Things { get; set; }  //<T> can be string or int etc. Two instances in Program.cs
    }
}
