using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRILL_114_Class_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //CLASS
            Methods method = new Methods();

            //CALL METHOD
            Console.WriteLine("The integer 10, will have 42 added.\n" + method.defaultMethod(10));

            Console.WriteLine("The decimel 349.50 will be converted to an integer and have 345 added to it. \n" + method.defaultMethod(349.50m));

            Console.WriteLine("The string value of 54 will be converted to an integer, and have 64 added to it.\n" + method.defaultMethod("54"));

            Console.ReadLine();

        }
    }
}
