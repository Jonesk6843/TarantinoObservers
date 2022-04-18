using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using TarantinoObserversLibrary;

namespace ConsoleUI
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

                //main menu
                while (exit == false)
                {
                    //Dropping certain mobs at certain steps
                    if (steps == 3)
                    {
                        foreach (Mob mob in World.mobs)
                        {
                            Console.WriteLine($"A {mob.name} stands in your way!");
                        }
                    }
                    //Display player menu
                    foreach (Room room in World.rooms)
                    {
                        Console.WriteLine($"You are in {room.name}");
                        Console.WriteLine(room.description);
                    }
                    Console.WriteLine("Make your choice, Observer.");
                    Console.WriteLine("Hp: 100 MP: 50 type (help) for controls.");
                    Console.Write("> ");
                    string input = Console.ReadLine();

                    
                    //Player input options
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
