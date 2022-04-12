using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TarantinoObserversLibrary
{
    public class MovementMenu
    {
        public static void UserMenu()
        {
            try
            {
                //Variables
                int steps = 0;
                int currentRoom = 1;
                bool exit = false;
                int hitpoints = 0;
                StreamReader inputFile;

                //Creating room list
                List<string> rooms = new List<string>();

                // Reading Room file
                inputFile = File.OpenText("Rooms.txt");
                while (inputFile.EndOfStream == false)
                {
                    rooms.Add(inputFile.ReadLine());
                }
                inputFile.Close();

                //main menu
                while (exit == false)
                {
                    Console.WriteLine("Make your choice, Observer.");
                    Console.WriteLine("Hp: 100 MP: 50 type (help) for controls.");
                    Console.Write("> ");
                    string input = Console.ReadLine();
                    switch (input.ToLower())
                    {
                        case "north":
                            if (steps != 4)
                            {
                                steps++;
                                currentRoom++;
                                Console.WriteLine();
                            }
                            else
                            {
                                Console.WriteLine("Looks like a dead end.");
                                Console.WriteLine();
                            }
                            break;

                        case "south":
                            if (steps != 0)
                            {
                                steps--;
                                currentRoom--;
                                Console.WriteLine();
                            }
                            else
                            {
                                Console.WriteLine("I can't leave yet!");
                                Console.WriteLine();
                            }
                            break;

                        case "attack":
                            {
                                CombatMenu.BattleMenu(ref hitpoints);
                                Console.WriteLine();
                            }
                            break;

                        case "exit":
                            Console.WriteLine("Until next time, Observer.");
                            Console.WriteLine("Press Enter to exit the program.");
                            Console.ReadLine();
                            exit = true;
                            break;
                        case "help":
                            {
                                Console.WriteLine("To move, type north, south, east, or west.");
                                Console.WriteLine("To attack, type Attack.");
                                Console.WriteLine("If you would like to exit the program, type Exit.");
                                Console.WriteLine("Casing does not matter.");
                                Console.WriteLine("Press Enter to exit help menu.");
                                Console.ReadLine();
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
