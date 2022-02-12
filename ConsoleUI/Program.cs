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
            //variables
            int steps = 0;

            //Arrays
            string[] rooms = new string[5] {"Entrance", "Abandoned Lobby Room", "Hallway", "Hallway #2", "King's Quarters"};
            string[] weapons = new string[4] {"Lance of the Round Table", "Shield of the Round Table", "Broken Sword", "Hammer of the High Orc"};
            Array.Sort<string>(weapons);
            string[] potions = new string[2] {"Elixer of Healing", "Stone Skin"};
            Array.Sort<string>(potions);
            string[] treasures = new string[3] {"Gold Pouch", "Goblin eye", "Crown of the High Orc"};
            Array.Sort<string>(treasures);

            //Lists
            List<string> items = new List<string>() {"Observer's Notebook", "Lockpick set", "Ink and feather", "Smoke Bombs"};
            items.Sort();
            List<string> mobs = new List<string>() {"Spider", "Gold Goblin", "Infantry Goblin", "High Knight Goblin" , "High Orc"};
            mobs.Sort();

            bool exit = false;
            //Main Menu
            while (exit == false)
            {
                Console.WriteLine($"Current Location - {rooms[steps]}");
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
                        Console.WriteLine();
                        break;
                    case "2":
                        foreach (string val in weapons)
                        {
                            Console.WriteLine(val);
                        }
                        Console.WriteLine();
                        break;
                    case "3":
                        foreach (string val in potions)
                        {
                            Console.WriteLine(val);
                        }
                        Console.WriteLine();
                        break;
                    case "4":
                        foreach (string val in treasures)
                        {
                            Console.WriteLine(val);
                        }
                        Console.WriteLine();
                        break;
                    case "5":
                        foreach (string val in items)
                        {
                            Console.WriteLine(val);
                        }
                        Console.WriteLine();
                        break;
                    case "6":
                        foreach (string val in mobs)
                        {
                            Console.WriteLine(val);
                        }
                        Console.WriteLine();
                        break;
                    case "7":
                        exit = true;
                        break;
                    case "rooms":
                        foreach (string val in rooms)
                        {
                            Console.WriteLine(val);
                        }
                        Console.WriteLine();
                        break;
                    case "weapons":
                        foreach (string val in weapons)
                        {
                            Console.WriteLine(val);
                        }
                        Console.WriteLine();
                        break;
                    case "potions":
                        foreach (string val in potions)
                        {
                            Console.WriteLine(val);
                        }
                        Console.WriteLine();
                        break;
                    case "treasures":
                        foreach (string val in treasures)
                        {
                            Console.WriteLine(val);
                        }
                        Console.WriteLine();
                        break;
                    case "items":
                        foreach (string val in items)
                        {
                            Console.WriteLine(val);
                        }
                        Console.WriteLine();
                        break;
                    case "mobs":
                        foreach (string val in mobs)
                        {
                            Console.WriteLine(val);
                        }
                        Console.WriteLine();
                        break;
                    case "s":
                        if (steps != 0)
                        {
                            steps--;
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("Maybe I missed something...");
                            Console.WriteLine();
                        }
                        break;
                    case "n":
                        if (steps != 4)
                        {
                            steps++;
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("Looks like a dead end.");
                            Console.WriteLine();
                        }
                        break;
                    default:
                        {
                            Console.WriteLine("Apologies. Come again?");
                            Console.WriteLine();
                            break;
                        }
                }
            }
        }
    }
}
