using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRILL_97
{
    class Program
    {
        static void Main(string[] args)
        {

            //STRINGS
            string name = "Tony Soprano";
            string liveIn = "New Jersey";
            string children = "two children";
            
            //CONCATENATE STRINGS
            string concatenate = "My name is " + name + ". I live in " + liveIn + " and I have " + children + ".";
            Console.WriteLine(concatenate);
            Console.ReadLine();

            name = name.ToUpper();
            Console.WriteLine(name);
            Console.ReadLine();

            //STRINGBUILDER
            StringBuilder TonyS = new StringBuilder();
            
            TonyS.Append("My name is Tony Soprano.");
            TonyS.Append(" I live in New Jersey.");
            TonyS.Append(" I am a mafia boss.");
            TonyS.Append(" I take so much prozac that I'm normally blasted out of my mind,");
            TonyS.Append(" and I have a serious crush on my psychiatrist.");


            Console.WriteLine(TonyS);
            Console.ReadLine();


        }
    }
}
