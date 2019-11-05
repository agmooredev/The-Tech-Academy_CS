using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRILL_75
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What is your age?");
            int Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI? Please answer with True or False.");
            bool DUI = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("How many speeding tickets do you have?");
            int Tickets = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("");
            bool Qualified = (Age > 15) && (DUI != true) && (Tickets <= 3);

            if (Qualified == true)
            {
                Console.WriteLine("Thank you, you're qualified!");
                }

            else
            { 
                Console.WriteLine("We're sorry, but you are not qualified at this time.");
            }

            Console.ReadLine();

        }
    }
}
