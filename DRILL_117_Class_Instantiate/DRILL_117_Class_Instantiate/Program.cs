using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRILL_117_Class_Instantiate
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Choose an integer to divide by 2");
            int inputNum = Convert.ToInt32(Console.ReadLine());

            Method num = new Method(); //INSTANTIATE CLASS
            num.divByTwo(inputNum); // DIVIDE INPUT BY 2
            Console.WriteLine("Press enter to continue..");
            Console.ReadLine();

            Method num2 = new Method(); //2ND INSTANTIATION FOR CLASS "INTEGER"
            int a, b;
            num2.Output(out a, out b); //OUTPUT PARAMATERS
            Console.WriteLine("The Value of a is: {0}", a);
            Console.WriteLine("The value of b is: {0}", b);

            Console.WriteLine("Press enter to continue..");
            Console.ReadLine();

            Method.Overload("string");
            Console.ReadLine();
        }
    }
}
