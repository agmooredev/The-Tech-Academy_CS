using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRILL_66
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Type a number to multiply by 50");
            string inputOne = Console.ReadLine();
            int numOne = Convert.ToInt32(inputOne);
            int totalOne = 50 * numOne;
            Console.WriteLine(totalOne);
            

            Console.WriteLine("Type a number to add 25 to");
            string inputTwo = Console.ReadLine();
            int numTwo = Convert.ToInt32(inputTwo);
            int totalTwo = numTwo + 25;
            Console.WriteLine(totalTwo);

            Console.WriteLine("Type a number to divide by 12.5");
            string inputThree = Console.ReadLine();
            int numThree = Convert.ToInt32(inputThree);
            double totalThree = numThree / 12.5;
            Console.WriteLine(totalThree);
          

            Console.WriteLine("Type a number to check if it is greater than 50");
            string inputFour = Console.ReadLine();
            int numFour = Convert.ToInt32(inputFour);
            bool truthorfalse = numFour > 50;
            Console.WriteLine(truthorfalse.ToString());
            

            Console.WriteLine("Type a number to divide by 7 and show the remainder");
            string inputFive = Console.ReadLine();
            int numFive = Convert.ToInt32(inputFive);
            int remain = 7 % numFive;
            Console.WriteLine(remain);
            Console.ReadLine();
            









        }
    }
}
