using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace inheritance
{
    class Coop: ICoop
    {
        int _id;
        string _name;
        ArrayList arr = new ArrayList();
        public int id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }

        public string name
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

        public System.Collections.ArrayList arrPoultry
        {
            get { return arr; }
        }

        public void contrain()
        {
            foreach (PouLtry p in arr)
            {
                p.Display();
                p.Speak();
            }
        }

        public void addChicken()
        {
            Chiken c = new Chiken(++PouLtry.Count, "");
            Console.Write("emter name chicken please  ");
            c.Name = Console.ReadLine();
            arr.Add(c);
        }

        public void addDuck()
        {
            Duck c = new Duck(++PouLtry.Count, "");
            Console.Write("emter name duck please  ");
            c.Name = Console.ReadLine();
            arr.Add(c);
        }

        public void removePoultry(int id)
        {
            foreach (PouLtry p in arr)
            {
                if(p.id == id)
                {
                    arr.Remove(p);
                    break;
                }
            }
        }
    }
}
