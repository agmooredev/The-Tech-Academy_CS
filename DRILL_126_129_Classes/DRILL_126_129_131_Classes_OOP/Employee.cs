using DRILL_126_129_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DRILL_126_129_Classes
{
    public class Employee : Person, IQuittable
    { 

        public int id { get; set; } 
        public void Integer()
        {
            id = 0;
        }

        public void Integer(int x)
        {
            id = x;
        }

        public static bool operator ==(Employee x, Employee y) //OBJ COMPARISON; CHK FOR EQUALITY
        {
            if (x.id == y.id)
            {
                Console.WriteLine("== yes");
                return true;
            }
            else
            {
                Console.WriteLine("== no");
                return false;
            }
        }

        public static bool operator !=(Employee x, Employee y) //OBJ COMPARISON; CHK FOR EQUALITY BOTH DIRECTIONS
        {
            if (x.id != y.id)
            {
                Console.WriteLine("!= yes");
                return true;
            }
            else
            {
                Console.WriteLine("!= no");
                return false;
            }
        }

        public int getVal()
        {
            return id;
        }

        public override void SayName()
        {
            Console.WriteLine("First Name: " + FirstName);
            Console.WriteLine("Last Name: " + LastName);

        }

        public void Quit()//QUIT() METHOD
        {
            Console.WriteLine("Quit() method is now active.");
        }
    }
        

    }
    

