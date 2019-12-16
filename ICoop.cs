using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace inheritance
{
    interface ICoop
    {
        int id { get; set; }
        string name {get; set;}

        ArrayList arrPoultry { get; }

        void contrain();

        void addChicken();

        void addDuck();

        void removePoultry(int id);
    }
}
