using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    interface IPoultry
    {
        int id {get;}
        string Name { get; set; }

        void Speak();
        void Display();
    }
}
