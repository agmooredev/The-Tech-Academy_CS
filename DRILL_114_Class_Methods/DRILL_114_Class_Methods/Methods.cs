using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRILL_114_Class_Methods
{
    class Methods
    {
        public int defaultMethod(int num) 
        {
            int result = num + 42; 
            return result;
        }

        public int defaultMethod(decimal num) 
        {
            int result = Convert.ToInt32(num) + 485; 
            return result;
        }

        public int defaultMethod(string num) 
        {
            int result = Convert.ToInt32(num) + 64; 
            return result;
        }
    }
}
