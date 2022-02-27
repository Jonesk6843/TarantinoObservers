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
using System.IO;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //variables
                bool exit = false;
                int steps = 0;
                StreamReader inputFile;
                StreamWriter outputFile;

                //Creating Arrays
                string[] userInfo = new string[3];
                string[] rooms = new string[5];

                //Creating Lists
                List<string> weapons = new List<string>();
                weapons.Sort();
                List<string> potions = new List<string>();
                potions.Sort();
                List<string> treasures = new List<string>();
                treasures.Sort();
                List<string> items = new List<string>();
                items.Sort();
                List<string> mobs = new List<string>();
                mobs.Sort();

                //Reading files
                
                //Rooms
                inputFile = File.OpenText("Rooms.txt");
                string str4 = inputFile.ReadLine();
                while (inputFile.EndOfStream == false)
                {
                    String[] tokens = inputFile.ReadLine().Split(':');
                    foreach (String token in tokens)
                    {
                        rooms.Add(token);
                    }
                }
                inputFile.Close();
                
                //Weapons
                inputFile = File.OpenText("Weapons.txt");
                string str2 = inputFile.ReadLine();

                while (inputFile.EndOfStream == false)
                {
                    String[] tokens = inputFile.ReadLine().Split(':');
                    foreach (String token in tokens)
                    {
                        weapons.Add(token);
                    }
                }
                inputFile.Close();
                
                //Potions
                inputFile = File.OpenText("Potions.txt");
                string str5 = inputFile.ReadLine();
                while (inputFile.EndOfStream == false)
                {
                    String[] tokens = inputFile.ReadLine().Split(':');
                    foreach (String token in tokens)
                    {
                        potions.Add(token);
                    }
                }
                inputFile.Close();

                //Treasures
                inputFile = File.OpenText("Treasures.txt");
                string str3 = inputFile.ReadLine();
                while (inputFile.EndOfStream == false)
                {
                    String[] tokens = inputFile.ReadLine().Split(':');
                    foreach (String token in tokens)
                    {
                        treasures.Add(token);
                    }
                }
                inputFile.Close();

                //Items
                inputFile = File.OpenText("Items.txt");
                string str6 = inputFile.ReadLine();
                while (inputFile.EndOfStream == false)
                {
                    String[] tokens = inputFile.ReadLine().Split(':');
                    foreach (String token in tokens)
                    {
                        items.Add(token);
                    }

                }
                inputFile.Close();

                //Mobs
                inputFile = File.OpenText("Mobs.txt");
                string str1 = inputFile.ReadLine();
                while (inputFile.EndOfStream == false)
                {
                    String[] tokens = inputFile.ReadLine().Split(':');
                    foreach (String token in tokens)
                    {
                        mobs.Add(token);
                    }
                }
                inputFile.Close();

                //Getting player information
                Console.WriteLine("Greetings, Observer!");

                Console.WriteLine("What is your name? >");
                string nameInput = Console.ReadLine();
                Console.WriteLine(nameInput + ". A name that will ring across the land!");
                Console.WriteLine("This is your observer handbook. Create a password so that only you may access it's contents. >");
                string passwordInput = Console.ReadLine();
                Console.WriteLine("Keep that password safe, okay?");
                Console.WriteLine("Finally, what class of Observer are you? A (Gunslinger), (Witch), or (standard) Observer? >");
                string classInput = Console.ReadLine();
                
                    Console.WriteLine("Finalized! You are now officially an Observer of the Tarantino Family! Now get out there and observe some monsters!");
                Console.WriteLine("Remember! Communication amongst monsters is key!");
                
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

                    switch (input.ToLower())
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
                catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
