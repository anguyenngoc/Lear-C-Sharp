using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            Farmhouse farmhouse = new Farmhouse();
            int leng1 = 0;
            int leng2 = 0;


            do
            {
                menu.menu();
                Console.Write("choise a menu: ");
                leng1 = int.Parse(Console.ReadLine());

                switch (leng1)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    default:
                        Console.WriteLine("Something wrong!");
                        break;
                }
            } while (leng1 != 7);
            
        }
    }
}
