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

            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Enter hourly rate then hours worked for both person 1 and 2");

            Console.WriteLine("Person 1");
            Decimal rate1 = Convert.ToDecimal(Console.ReadLine());
            short hours1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Person 2");
            Decimal rate2 = Convert.ToDecimal(Console.ReadLine());
            short hours2 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Weekly salary of Person 1:");
            Console.WriteLine(rate1 * hours1);

            Console.WriteLine("Weekly salary of Person 2:");
            Console.WriteLine(rate2 * hours2);

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Boolean makeMore = (rate1 * hours1) > (rate2 * hours2);
            Console.WriteLine(makeMore);










        }
    }
}
