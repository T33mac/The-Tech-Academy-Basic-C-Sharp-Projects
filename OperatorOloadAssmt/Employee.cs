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


        //public static bool operator ==(**** a1, **** a2)      //Trying to get instances from list "lstEmp" created in Main
        //{
        //    foreach (Employee a1 in ****, Employee b1 in ****)
        //    {
        //        if (a1.Id == b1.Id)
        //        {
        //            Console.WriteLine(a1.Id + " appears more than once in this list!");
        //        }
        //        else if (a1.Id != b1.Id)
        //        {
        //            Console.WriteLine("Everything looks in order");
        //        }
        //        else
        //        {
        //            Console.WriteLine("Someting must be wrong.");
        //        }
        //        return a1;
        //    }
        //}
        //public static bool operator !=(**** a1, **** b1)
        //{
        //    return !(a1 == b1);
        //}
    }
}
