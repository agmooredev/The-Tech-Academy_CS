using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRILL_120_Inheritance
{
    class Program
    {

        static void Main(string[] args)
        {
            Employee empObject = new Employee(); //EMPLOYEE OBJECT
            empObject.FirstName = "Sample"; //INSTANTIATE 'empObject'
            empObject.LastName = "Student"; 
            empObject.SayName(); //CALL SUPERCLASS "SAYNAME()" 
            Console.ReadLine();
        }
    }
}

