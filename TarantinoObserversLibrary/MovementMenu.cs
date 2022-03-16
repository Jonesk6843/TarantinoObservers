using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarantinoObserversLibrary
{
    public class MovementMenu
    {
        public static void UserMenu(ref string rooms)
        {
            try
            {
                //Variables
                int steps = 0;
                bool exit = false;

                //main menu
                while (exit == false)
                {
                    Console.WriteLine($"Current Location - {rooms[steps]}");
                    Console.WriteLine("1.) Move North");
                    Console.WriteLine("2.) Move South");
                    Console.WriteLine("3.) Attack");
                    Console.WriteLine("4.) Exit");
                    Console.Write("Make your choice, Observer. >");
                    string input = Console.ReadLine();
                    switch (input.ToLower())
                    {
                        case "1":
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

                        case "2":
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

                        case "3":
                            {
                                Console.WriteLine("Not built yet...");
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
                                Console.WriteLine();
                            }
                            else
                            {
                                Console.WriteLine("Looks like a dead end.");
                                Console.WriteLine();
                            }
                            break;

                        case "South":
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

                        case "Combat":
                            {
                                Console.WriteLine("Not built yet...");
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
