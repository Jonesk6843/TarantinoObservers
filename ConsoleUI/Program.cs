/**
* 2/10/22
* CSC 153
* Kent Jones Jr
* A text adventure of the first level of the Tarantino Observers.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arrays
            string[] rooms = new string[5] {"Entrance", "Abandoned Lobby Room", "Hallway", "Hallway #2", "King's Quarters"};
            string[] weapons = new string[4] {"Lance of the Round Table", "Shield of the Round Table", "Broken Sword", "Hammer of the High Orc"};
            string[] potions = new string[2] {"Elixer of Healing", "Stone Skin"};
            string[] treasures = new string[3] {"Gold Pouch", "Goblin eye", "Crown of the High Orc"};

            //Lists
            List<string> items = new List<string>() {"Observer's Notebook", "Lockpick set", "Ink and feather", "Smoke Bombs"};
            List<string> mobs = new List<string>() {"Spider", "Gold Goblin", "Infantry Goblin", "High Knight Goblin" , "High Orc"};

            bool exit = false;
            //Main Menu
            while (exit == false)
            {
                Console.WriteLine("Welcome, Observer!");
                Console.WriteLine("1.) Display Rooms");
                Console.WriteLine("2.) Display Weapons");
                Console.WriteLine("3.) Display Potions");
                Console.WriteLine("4.) Display Treasures");
                Console.WriteLine("5.) Display Items");
                Console.WriteLine("6.) Display Mobs");
                Console.WriteLine("7.) Exit");
                Console.Write("Make your choice, Observer. >");
                string input = Console.ReadLine();
                
                switch(input.ToLower())
                {
                    case "1":
                        foreach (string val in rooms)
                        {
                            Console.WriteLine(val);
                        }
                        break;
                    case "2":
                        foreach (string val in weapons)
                        {
                            Console.WriteLine(val);
                        }
                        break;
                    case "3":
                        foreach (string val in potions)
                        {
                            Console.WriteLine(val);
                        }
                        break;
                    case "4":
                        foreach (string val in treasures)
                        {
                            Console.WriteLine(val);
                        }
                        break;
                    case "5":
                        foreach (string val in items)
                        {
                            Console.WriteLine(val);
                        }
                        break;
                    case "6":
                        foreach (string val in mobs)
                        {
                            Console.WriteLine(val);
                        }
                        break;
                    case "7":
                        exit = true;
                        break;
                    case "rooms":
                        foreach (string val in rooms)
                        {
                            Console.WriteLine(val);
                        }
                        break;
                    case "weapons":
                        foreach (string val in weapons)
                        {
                            Console.WriteLine(val);
                        }
                        break;
                    case "potions":
                        foreach (string val in potions)
                        {
                            Console.WriteLine(val);
                        }
                        break;
                    case "treasures":
                        foreach (string val in treasures)
                        {
                            Console.WriteLine(val);
                        }
                        break;
                    case "items":
                        foreach (string val in items)
                        {
                            Console.WriteLine(val);
                        }
                        break;
                    case "mobs":
                        foreach (string val in mobs)
                        {
                            Console.WriteLine(val);
                        }
                        break;
                    case "s":
                        //TODO
                        break;
                    case "n":
                        //TODO
                        break;
                    default:
                        //TODO
                        break;

                }

                //if (input == "1")
                //{
                //    //TODO
                //}
                //else if (input == "2")
                //{
                    
                //}
                //else if (input == "3")
                //{
                //    ;
                //}
                //else if (input == "4")
                //{
                //    ;
                //}
                //else if (input == "5")
                //{
                //    ;
                //}
                //else if (input == "6")
                //{
                //    exit = true;
                //}
                //else
                //{
                //    Console.WriteLine("Apologies. Come again?");
                //}
            }
        }
    }
}
