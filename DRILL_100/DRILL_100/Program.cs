using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRILL_100
{
    class Program
    {
        static void Main(string[] args)
        {
            //ARRAY OF STRINGS
            string[] cityArray = new string[] { "Bangkok", "Seattle", "Frankfurt", "London", "Tokyo", "Seoul" };
            Console.WriteLine("Choose a number from 0-5 to display the city at that index of the array.");
            //DEFINE INPUT VARIABLE
            int input = Convert.ToInt32(Console.ReadLine());
            //WHILE LOOP FOR DETECTING INCORRECT INPUT VALUE
            while (input < 0 || input > 5)
            {
                Console.WriteLine("FAIL...index values 0-5 only, fool.. ");
                input = Convert.ToInt32(Console.ReadLine());
            }
            //DISPLAY INDEX VALUE
            Console.WriteLine("The city at index " + input + " is " + cityArray[input]);
            Console.ReadLine();
            
            //ARRAY OF INTEGERS
            int[] intArray = { 0, 1, 50, 100, 500, 1000, 10000 };
            Console.WriteLine("Choose a number from 0-6 to display the integer at that index of the array.");
            int inputInt = Convert.ToInt32(Console.ReadLine());
            //WHILE LOOP FOR DETECTING INCORRECT INPUT VALUES
            while (inputInt < 0 || inputInt > 6)
            {
                Console.WriteLine("FAIL.. 0-6 only. How many times I gotta tell you..??");
                inputInt = Convert.ToInt32(Console.ReadLine());
            }
            //DISPLAY INDEX VALUE
            Console.WriteLine("The integer at index " + inputInt + " is " + intArray[inputInt]);
            Console.ReadLine();

            //LIST OF STRINGS
            List<string> cityList = new List<string>();
            cityList.Add("Guangzhou");
            cityList.Add("Shenzhen");
            cityList.Add("Hanoi");
            cityList.Add("Osaka");
            cityList.Add("Hong Kong");
            
            //DEFINE INPUT VARIABLE
            Console.WriteLine("Choose a number from 0-4 to display the city at that index of the list.");
            int listInput = Convert.ToInt32(Console.ReadLine());
            //WHILE LOOP FOR DETENCTING INCORRECT INPUT VALUE
            while (listInput < 0 || listInput > 5)
            {
                Console.WriteLine("Error. Please enter a number between 0 and 5.");
                listInput = Convert.ToInt32(Console.ReadLine());
            }
            //DISPLAY INDEX VALUE
            Console.WriteLine("The color at index " + listInput + " is " + cityList[listInput]);
            Console.ReadLine();

        }
    }
}
