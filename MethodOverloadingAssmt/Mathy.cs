using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloadingAssmt
{
    public class Mathy
    {
        public int Calculate(int num1)
        {
            int math1 = num1 + 55;
            return math1;
        }
        public int Calculate(decimal num2)
        {
            decimal mathy = num2 / 14;
            int math2 = Convert.ToInt32(mathy);
            return math2;
        }
        
        public int Calculate(string num3)
        {
            int math3 = Convert.ToInt32(num3) * 2;
            return math3;
        }
    }
}
