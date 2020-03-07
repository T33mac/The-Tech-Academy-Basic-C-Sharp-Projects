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
        public static bool operator ==(Employee emp, Employee emp1)
        {
            return emp.Id == emp1.Id;
        }
        public static bool operator !=(Employee emp, Employee emp1)
        {
            return emp.Id != emp1.Id;
        }
    }

}
