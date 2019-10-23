using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is a simple program 
            //Console.WriteLine("What is your name?");
            //string yourname = Console.ReadLine();
            //Console.WriteLine("Your name is: " + yourname);
            //Console.ReadLine();

            //Console.WriteLine("What is your favorite number?");
            //string favNum = Console.ReadLine();
            //int total = favNum + 5;
            //Console.WriteLine("Your favorite number plsu 5 is: " + total);
            //Console.ReadLine();

            bool isStudying = false;
            byte hoursWorked = 42;
            char randomLetter = 'X'
            decimal moneyInBank = 100.5m;
            float secondsLeft = 2.62f;


            int currentAge = 30;
            string yearsOld = currentAge.ToString();

            bool isRaining = true;
            string rainingStatus = Convert.ToString(isRaining);
            Console.WriteLine(rainingStatus);
            Console.ReadLine();
           

        }
    }
}
