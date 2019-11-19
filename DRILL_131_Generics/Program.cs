using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRILL_131_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericStringList<string> colors = new GenericStringList<string>(); //INSTANTIATE EMPLOYEE OBJECT W/STRING GENERIC PARAMETER
            colors.colors = new List<string>() { "red", "green", "blue", "yellow" }; //ASSIGN LIST OF STRINGS AS PROP VALUE OF "THINGS"

            foreach (string color in colors.colors) //CREATE LOOP TO PRINT ALL THINGS TO CONSOLE
            {
                Console.WriteLine(color); 
            }

            GenericIntList<int> number = new GenericIntList<int>(); //INSTANTIATE EMP OBJ W/INT AS GEN PARAMETER
            number.nums = new List<int>() { 100, 50, 75, 200 }; //ASSIGN LIST OF INTEGERS AS PROPERTY OF "THINGS"
                
            foreach (int numberOutput in number.nums) //CREATE LOOP TO PRINT ALL THINGS TO CONSOLE
            {
                Console.WriteLine(numberOutput); //CREATE LOOP TO PRINT ALL THINGS TO CONSOLE
            }

            Console.ReadLine();
        }
    }
}
