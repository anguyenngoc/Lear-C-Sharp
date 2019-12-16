using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Farmhouse
    {
        public static int CID = 0;
        public Dictionary<int, Coop> coopList = new Dictionary<int, Coop>();

        public void addCoop()
        {
            Coop coop = new Coop();
            coop.id = ++CID;
            Console.Write("nhap ten: ");
            coop.name = Console.ReadLine();
            coopList.Add(coop.id, coop);
        }

        public void RemoveCoop(int id)
        {
            if (coopList.ContainsKey(id))
            {
                coopList.Remove(id);
            }
        }

        public void ToSpeakInChorus()
        {
            foreach (Coop c in coopList.Values)
            {
                foreach (PouLtry p in c.arrPoultry)
                {
                    p.Speak();
                }
            }
        }

        public void Show()
        {
            foreach (Coop c in coopList.Values)
            {
                c.contrain();
            }
        }


    }

   
}
