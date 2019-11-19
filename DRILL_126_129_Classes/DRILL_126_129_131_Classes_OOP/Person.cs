using DRILL_126_129_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRILL_126_129_Classes
{
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }


        public abstract void SayName();
    }

 }  
  

