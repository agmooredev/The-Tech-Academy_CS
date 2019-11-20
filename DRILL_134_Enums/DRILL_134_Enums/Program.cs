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
            try // TRY/CATCH BLOCK
            {
                Console.WriteLine("Enter the current day of the week"); //PROMPT USER
                string currentDay = Console.ReadLine();
                DayOfWeek day = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), currentDay, true); //ASSIGN VAL TO VAR OF ENUM
                Console.WriteLine("Today is " + day);
            }

            catch (Exception ex)  //PRINT ERROR FOR INCORRECT DATA ENTRY
            {
                Console.WriteLine("Error. Please enter an actual day of the week");
            }

            finally
            {
                Console.ReadLine();
            }
        }
    }
}

