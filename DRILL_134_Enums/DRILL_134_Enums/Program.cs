using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRILL_134_Enums
{
    class Program
    {
        //ENUM FOR DAYS OF THE WEEK
        public enum DayofWeek { monday, tuesday, wednesday, thursday, friday, saturday, sunday };

        static void Main(string[] args)
        {

            start:
            try // TRY/CATCH BLOCK
            {
                Console.WriteLine("Enter the current day of the week"); //PROMPT USER
                string currentDay = Console.ReadLine();

                if (int.TryParse(currentDay, out int x))
                {
                    throw new System.Exception("You cannot enter a number value");
                    goto start;
                    //Console.WriteLine("Please enter a number");
                }

                else
                {

                    DayOfWeek day = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), currentDay, true); //ASSIGN VAL TO VAR OF ENUM
                    Console.WriteLine("Today is " + day);
                }
            }

            catch (Exception ex)  //PRINT ERROR FOR INCORRECT DATA ENTRY
            {
                Console.WriteLine("Error. Please enter an actual day of the week");
                Console.WriteLine(ex);
                goto start;
            }

            finally
            {
                Console.ReadLine();

 
            }
        }
    }
}
        
    


