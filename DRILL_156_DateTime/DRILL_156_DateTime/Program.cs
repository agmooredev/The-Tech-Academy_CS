using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRILL_156_DateTime
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                DateTime currentDateTime = DateTime.Now; 
                Console.WriteLine(currentDateTime);
                Console.WriteLine("Enter a whole number to see what time it will be in your chosen number of hours"); 
                TimeSpan Xhours = TimeSpan.FromHours(Convert.ToDouble(Console.ReadLine()));
                DateTime inXHours = currentDateTime + Xhours;
                Console.WriteLine("The exact time will be: " + inXHours); 

                Console.Read();
            }
        }
    }
}
    

