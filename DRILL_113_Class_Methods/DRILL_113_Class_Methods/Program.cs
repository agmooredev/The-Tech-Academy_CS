using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRILL_113_Class_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Choose an whole integer to add 50 to.");
            int inputOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choose another integer to display.");
            int inputTwo = Convert.ToInt32(Console.ReadLine());

            Integers numbers = new Integers();
            numbers.Add(inputOne, inputTwo);
            numbers.Add(num: inputOne, num2: inputOne);

        

             Console.ReadLine();
        }
    }
}
