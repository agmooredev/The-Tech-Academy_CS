using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRILL_67
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();

            Console.WriteLine("Enter the hourly rate of person 1");
            Decimal person1rate = Convert.ToDecimal(Console.ReadLine());


            Console.WriteLine("Enter the hours worked for person 1");
            short person1hours = Convert.ToInt16(Console.ReadLine());


            Console.WriteLine("Enter the hourly rate of person 2");
            Decimal person2rate = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter the hours worked for person 2");
            short person2hours = Convert.ToInt16(Console.ReadLine());


            Console.WriteLine("Weekly salary of Person 1:");
            Console.WriteLine(person1rate * person1hours);

            Console.WriteLine("Weekly salary of Person 2:");
            Console.WriteLine(person2rate * person2hours);

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Boolean earnMore = (person1rate * person1hours) > (person2rate * person2hours);
            Console.WriteLine(earnMore);

            Console.ReadLine();




        }
    }
}
