using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRILL_162_Contructors_AdditionalFeat
{
 
    
        public class Person
        {
            //CONST VARIABLE
            const string colorOfSky = "Blue";


            public string First;
            public string Last;
            public int Age;

            //CHAIN 2 CONSTRUCTORS TOGETHER
            public Person(string name) : this(name, "-", 0)
            {
                var First = name; 
            }

            public Person(string name, string surname) : this(name, surname, 0)
            {
                First = name;
                Last = surname;
            }

            public Person(string name, string surname, int integer)
            {
                First = name;
                Last = surname;
                Age = integer;
            }

            public void printName()
            {
                Console.WriteLine(First + " " + Last + "," + Age);
            }
        }
    }


