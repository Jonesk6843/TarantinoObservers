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
                    Console.WriteLine(currentRoom + $". {rooms[steps]}");
                    Console.WriteLine("1.) Move North");
                    Console.WriteLine("2.) Move South");
                    Console.WriteLine("3.) Attack");
                    Console.WriteLine("4.) Exit");
                    Console.WriteLine("Make your choice, Observer.");
                    Console.Write("> ");
                    string input = Console.ReadLine();
                    switch (input.ToLower())
                    {
                        case "1":
                            if (steps != 4)
                            {
                                steps++;
                                currentRoom++;
                                Console.WriteLine();
                            }
                            else
                            {
                                Console.WriteLine("Looks like a dead end...");
                                Console.WriteLine();
                            }
                            break;

                        case "2":
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

                        case "3":
                            {
                                CombatMenu.BattleMenu(ref hitpoints);
                                Console.WriteLine();
                            }
                            break;

                        case "4":
                            exit = true;
                            break;

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
                            exit = true;
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
