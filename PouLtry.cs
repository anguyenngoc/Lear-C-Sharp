using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class PouLtry: IPoultry
    {
        public static int Count = 0;
        int _id;
        string _name;

        public int id
        {
            get { return _id; }
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public void Speak()
        {
            Console.WriteLine("I speak english");
        }

        public void Display()
        {
            Console.WriteLine("id" + _id);
            Console.WriteLine("name" + _name);

        }

        public PouLtry()
        {
            _id = 0;
            _name ="";
        }
        public PouLtry(int id, string name)
        {
            _id = id;
            _name = name;
        }
    }
}
