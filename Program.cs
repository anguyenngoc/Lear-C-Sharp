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
            string leng2 = "";


            do
            {
                menu.menu();
                Console.Write("choise a menu: ");
                leng1 = int.Parse(Console.ReadLine());

                switch (leng1)
                {
                    case 1:
                        farmhouse.addCoop();
                        break;
                    case 2:
                          Console.Write("enter a ID to remove : ");
                          farmhouse.RemoveCoop(int.Parse(Console.ReadLine()));
                        break;
                    case 3:
                        Console.Write("input coop id: ");
                        string coopid = Console.ReadLine();
                        if (farmhouse.coopList.ContainsKey(int.Parse(coopid)))
                        {
                            Coop coop = farmhouse.coopList[int.Parse(coopid)];
                            do
                            {
                                Console.WriteLine("a. add a new chicken");
                                Console.WriteLine("b. add a new duck");
                                Console.Write("choise a menu: ");
                                leng2 = Console.ReadLine();
                                switch (leng2)
                                {
                                    case "a":
                                        coop.addChicken();
                                        break;
                                    case "b":
                                        coop.addDuck();
                                        break;
                                }
                            } while (leng2 == "a" || leng2 == "b");
                        }

                        break;
                    case 4:
                        Console.Write("input poultry id: ");
                        int pid = int.Parse(Console.ReadLine());
                        foreach(Coop coo in farmhouse.coopList.Values){
                            coo.removePoultry(pid);
                        }
                        break;
                    case 5:
                        farmhouse.Show();
                        break;
                    case 6:
                        farmhouse.ToSpeakInChorus();
                        break;
                    case 7:
                        Console.WriteLine("End");
                        break;
                    default:
                        Console.WriteLine("Something wrong!");
                        break;
                }
            } while (leng1 != 7);
            
        }
    }
}
