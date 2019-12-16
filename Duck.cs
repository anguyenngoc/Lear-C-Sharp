using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Duck: PouLtry
    {
        public void Speak()
        {
            Console.WriteLine("Quac Quac quac");
        }

        // building controcter inheritance class base, no parammeter
        public Duck():base()
        {

        }

        // building controcter inheritance class base, with parameters
        public Duck(int id, string name):base()
           
        {

        }
    }
}
