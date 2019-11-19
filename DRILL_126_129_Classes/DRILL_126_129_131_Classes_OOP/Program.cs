using DRILL_126_129_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DRILL_126_129_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee int1 = new Employee();
            Employee int2 = new Employee();

            int1.id = 23;
            int2.id = 23;


            bool yes = int1 == int2;


            Employee empObject = new Employee();
            empObject.FirstName = "Sample";
            empObject.LastName = "Student";
            empObject.SayName();

            Console.ReadLine();

            
            
                

                IQuittable quit = new Employee();
                //'IQUITTABLE' OBJECT THAT ALLOWS 'EMPLOYEE' CLASS TO INHERIT
                quit.Quit(); //CALL METHOD QUIT()


                Console.ReadLine();
            }
        }
    }

