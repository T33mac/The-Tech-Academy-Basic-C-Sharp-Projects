using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperClassAssmt
{
    public class Employee : Person
    {
        public void IdNum()
        {
            throw new NotImplementedException();            
        }
        public int Id { get; set; }
    }
}
