using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRILL_106_Exeption_Handling
{
    class Program
    {
        static void Main(string[] args)
        {

            //TRY-CATCH BLOCK
            try
            {
                //LIST OF INTEGERS
                List<int> numbers = new List<int>() { 1, 2, 4, 24, 536, 1543 };
                Console.WriteLine("Enter a number to divide each number in the list by.");
                string numInput = Console.ReadLine();
                int numDiv = Convert.ToInt32(numInput);

                for (int i = 0; i < numbers.Count; i++)
                {
                    Console.WriteLine(numbers[i] / numDiv);
                }

                Console.ReadLine();
            }

            catch (FormatException ex)
            {
                Console.WriteLine("Error. Type a whole number");
                return;
            }

            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error. You cannot divide by zero.");
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           


            finally
            {
                Console.ReadLine();

            }
        }
    }

}
