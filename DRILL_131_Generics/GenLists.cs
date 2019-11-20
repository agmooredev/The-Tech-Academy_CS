using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRILL_131_Generics
{

    class GenLists<Things> //PROPERTY "THINGS"
    {
        public List<Things> things; //PROP VALUE OF "THINGS" = LIST

        public void write(List<Things> list)
        {
            foreach (Things Tc in list) //CREATE LOOP TO PRINT ALL THINGS TO CONSOLE

            {
                Console.WriteLine(Tc);
            }

        }

    }
}





