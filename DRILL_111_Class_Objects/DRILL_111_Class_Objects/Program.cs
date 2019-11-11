using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRILL_111_Class_Objects
{
    class Program
    {
        static void Main(string[] args)
        {

                Console.WriteLine("Choose a whole integer you would like to do math operations with.");
                int inputNum = Convert.ToInt32(Console.ReadLine());

                IntOne numberOne = new IntOne();
                Console.WriteLine(numberOne.AddTen(inputNum));
                Console.WriteLine(numberOne.SubtractTen(inputNum));
                Console.WriteLine(numberOne.MultiplybyTen(inputNum));




                Console.ReadLine();
            }
    }
}
