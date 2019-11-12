using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRILL_117_Class_Instantiate
{
    class Operations
    {
        public void divByTwo(int num) //VOID METHOD OUTPUTING INT
        {
            Console.WriteLine(num / 2); //DIVIDE INT BY TWO
        }



        public void Output(out int a, out int b) //METHOD WITH OUTPUT PARAMETERS
        {
            Console.WriteLine("Enter a value to be assigned to 'a' parameter.");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a value to be assigned to 'b' parameter.");
            b = Convert.ToInt32(Console.ReadLine());
        }

       
    }
}
