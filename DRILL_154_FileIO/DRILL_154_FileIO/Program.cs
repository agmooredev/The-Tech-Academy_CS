using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DRILL_154_FileIO
{
    class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Enter a number that will be logged to a .txt file");
                string text = Console.ReadLine();
                File.WriteAllText(@"C:\Users\novac\Documents\GitHub\The-Tech-Academy_CS\DRILL_154_FileIO\Log.txt", text);
                string printNumber = File.ReadAllText(@"C:\Users\novac\Documents\GitHub\The-Tech-Academy_CS\DRILL_154_FileIO\Log.txt");
                Console.WriteLine("Number that was logged to Log.txt is: " + " " + printNumber);

                Console.ReadLine();
            }
        }

    }

    

