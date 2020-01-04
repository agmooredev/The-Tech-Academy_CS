using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRILL_115_Class_Methods_OptionalParameters_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a whole integer.");
            int inputOne = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Choose a 2nd integer (optional).");
            string inputOptional = Console.ReadLine();

            Integer method = new Integer();

            if (int.TryParse(inputOptional, out int optInteger))
            {

                Console.WriteLine(method.Add(optInteger, inputOne));
            }

            else

            Console.WriteLine(method.Add(inputOne));

            Console.ReadLine();

        }
    }
}
