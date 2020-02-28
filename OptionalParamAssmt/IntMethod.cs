using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParamAssmt
{
    public class IntMethod
    {
        public int DoThis(int num1, int num2 = 4)
        {
            int math1 = num1 * num2;
            return math1;
        }
    }
}
