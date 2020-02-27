using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObjectAssmt
{
    public class Calculations
    {
        public Calculations()
        {
            Program Val = new Program();
            int newNum = Convert.ToInt32(Val.nummy);
            int ans1 = newNum / 5;
            int ans2 = newNum + 13;
            int ans3 = newNum * 2;
        }
        public int ans1 { get; set; }
        public int ans2 { get; set; }
        public int ans3 { get; set; }
    }
}
