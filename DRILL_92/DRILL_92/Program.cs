using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRILL_92
{
    class Program
    {
        static void Main(string[] args)
        {

            //Greeting
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            //Inquire package weight
            Console.WriteLine("What is the weight of your package (lbs)");
            double totalWeight = Convert.ToDouble(Console.ReadLine());
            if (totalWeight > 50)
            {
                Console.WriteLine("Package is too heavy to be shipped by Package Express. Have a good day.");
                Console.ReadLine();
                Environment.Exit(1);
            }

            //Inquire package dimensions
            Console.WriteLine("What is the Length of your package? (Inches)");
            double totalLength = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is the Width of your package? (Inches)");
            double totalWidth = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is the Height of your package? (Inches)");
            double totalHeight = Convert.ToDouble(Console.ReadLine());
            //Check to see if package size is acceptable 
            double totalDimensions = (totalLength + totalWidth + totalHeight);
            if (totalDimensions > 50)
            {
                Console.WriteLine("We're sorry, your package is too big to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                Environment.Exit(1);
            }
            //Generate quote
            double totalBulk = (totalDimensions * totalWeight) / 100;

            Console.WriteLine("Your estimated total for shipping this package is : $" + totalBulk);
            Console.ReadLine();
        }
    }
}
