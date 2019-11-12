using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRILL_117_Class_Instantiate
{
    static class TheLastClass
    {

        public static void Overload(int num)
        {
            Console.WriteLine("Overload(int)");
        }

        public static void Overload(string text)
        {
            Console.WriteLine("Overload(string)");
        }
    }
}
