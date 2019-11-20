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
            GenLists<string> colors = new GenLists<string>(); //INSTANTIATE EMPLOYEE OBJECT W/STRING GENERIC PARAMETER
            colors.things = new List<string>() { "red", "green", "blue", "yellow" }; //ASSIGN LIST OF STRINGS AS PROP VALUE OF "THINGS"

            colors.write(colors.things);

            GenLists<int> number = new GenLists<int>(); //INSTANTIATE EMP OBJ W/INT AS GEN PARAMETER
            number.things = new List<int>() { 100, 50, 75, 200 }; //ASSIGN LIST OF INTEGERS AS PROPERTY OF "THINGS"
            number.write(number.things);



            Console.ReadLine();
        }
    }
}
