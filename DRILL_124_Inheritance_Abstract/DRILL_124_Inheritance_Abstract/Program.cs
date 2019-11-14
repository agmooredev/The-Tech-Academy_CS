using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRILL_124_Inheritence
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee empObject = new Employee(); 
            empObject.FirstName = "Sample"; 
            empObject.LastName = "Student"; 
            empObject.SayName(); 

            Console.ReadLine();

        }
    }
}
