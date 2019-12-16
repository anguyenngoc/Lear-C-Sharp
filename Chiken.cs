using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Chiken: PouLtry
    {
        public void Speak()
        {
            Console.WriteLine("O o O oo");
        }

        //building contructor

        public Chiken():base()
        {

        }

        public Chiken(int id, string name)
            : base(id,name)
        {

        }

    }
}
