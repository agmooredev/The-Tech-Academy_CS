using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRILL_140_Lambda_Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            //OBJ CREATION
            List<Employee> list = new List<Employee>();

            //CREATE LIST W/ => 10 EMPLOYEES W/ FNAME, LNAME, ID, and 2 EMP W/ FNAME = "JOE"
            list.Add(new Employee { FirstName = "Kumiko", LastName = "Oakinawa", Id = 001 });
            list.Add(new Employee { FirstName = "Peter", LastName = "Vira", Id = 002 });
            list.Add(new Employee { FirstName = "John", LastName = "Franklin", Id = 003 });
            list.Add(new Employee { FirstName = "Dustin", LastName = "Billanger", Id = 004 });
            list.Add(new Employee { FirstName = "Harrison", LastName = "Ford", Id = 005 });
            list.Add(new Employee { FirstName = "Joe", LastName = "Guage", Id = 006 });
            list.Add(new Employee { FirstName = "Frank", LastName = "Smith", Id = 007 });
            list.Add(new Employee { FirstName = "Jennifer", LastName = "Flynn", Id = 008 });
            list.Add(new Employee { FirstName = "Sam", LastName = "Zere", Id = 009 });
            list.Add(new Employee { FirstName = "Jared", LastName = "Martino", Id = 010 });


            //OBJ CREATION
            List<Employee> joe = new List<Employee>();

            //USE FOREACH LOOP TO CREATE LIST OF EMPLOYEES W/ FNAME = "JOE"
            foreach (Employee name in list)
            {
                if (name.FirstName == "Joe")
                {
                    joe.Add(new Employee { FirstName = name.FirstName, LastName = name.LastName, Id = name.Id });
                }
            }

            foreach (Employee name in joe)
            {
                Console.WriteLine(name.FirstName + " " + name.LastName + " " + name.Id);
            }



            //LAMBDA EXPRESSION TO PERFORM SAME FUNCTION AS ABOVE
            List<Employee> joeLambda = list.Where(n => n.FirstName == "Joe").ToList();

            foreach (Employee name in joeLambda)
            {
                Console.WriteLine(name.FirstName + " " + name.LastName + " " + name.Id);
            }

            Console.WriteLine("Employees named Joe");
            Console.ReadLine();

            //LAMBDA EXPRESSION TO CREATE EMP LIST W/ ID > 5
            List<Employee> greaterThan = list.Where(x => x.Id > 5).ToList();

            foreach (Employee name in greaterThan)
            {
                Console.WriteLine(name.FirstName + " " + name.LastName + " " + name.Id);
            }

            Console.WriteLine("Employees with ID greater than 5");
            Console.Read();



        }
    }
}
