using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRILL_57
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.Read();

            Console.WriteLine("What course are you on?");
            string courseOn = Console.ReadLine();
            Console.ReadLine();

            Console.WriteLine("What page number?");
            int pageNum = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Do you need help with anything? Please answer “true” or “false”.");
            bool help = Convert.ToBoolean(Console.ReadLine());


            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string experiance = Console.ReadLine();
            

            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            

            Console.WriteLine("How many hours did you study today?");
            int studyHours = Convert.ToInt32(Console.ReadLine());
           
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();

        }
    }
}
