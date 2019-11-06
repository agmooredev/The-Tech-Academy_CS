using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRILL_94
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                //WHILE LOOP
                Console.WriteLine("I'm thinking of a number between 1 and 10. Can you guess the number?");
                string number = Console.ReadLine();
                bool numberGuessed = number == "8";

                while (!numberGuessed)
                {
                    switch (number)
                    {
                        case "8":
                            Console.WriteLine("You're right! Congratulations, your accomplishment is truly unequivocal.");
                            numberGuessed = true;
                            break;

                        default:
                            Console.WriteLine("That is incorrect. What's the matter with you? Seriously..");
                            Console.WriteLine("Try again, I dare ya!");
                            number = Console.ReadLine();
                            break;
                    }
                }
                //DO WHILE LOOP
                Console.WriteLine("DO WHILE LOOP demo. Press enter to continue...");
                Console.ReadLine();

                Console.WriteLine("I'm thinking of a number between 1 and 10. Can you guess the number?");
                string inputNumber = Console.ReadLine();
                bool correctNumber = inputNumber == "5";

                do
                {
                    switch (inputNumber)
                    {
                        case "5":
                            Console.WriteLine("Well done. Program will self-destruct in exactly that many seconds..");
                            correctNumber = true;
                            break;

                        default:
                            Console.WriteLine("Nope, FAIL!!");
                            Console.WriteLine("Try again already, fool..");
                            inputNumber = Console.ReadLine();
                            break;
                    }
                }

                while(!correctNumber);

                Console.ReadLine();


            }
        }
    }
}

