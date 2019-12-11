using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRILL_165_Exeptions2_Try_Catch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("How old are you?"); 
                int age = Convert.ToInt32(Console.ReadLine());
                if (age <= 0) { throw new FormatException(); }
                if (age > 110) { throw new Exception(); }
                int year = 2019 - age;
                Console.WriteLine("You were likely born in " + year); 
                Console.ReadLine();
            }

            catch (FormatException ex)
            {
                Console.WriteLine("Error. Zero or negative numbers are not valid"); 
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





        
    

