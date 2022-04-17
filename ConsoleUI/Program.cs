/**
* 2/10/22
* CSC 153
* Kent Jones Jr
* A text adventure of the first area of the Tarantino Observers.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using TarantinoObserversLibrary;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //load the game world
                Load.loadRoom();
                Load.loadItems();
                Load.loadTreasures();
                Load.loadWeapons();
                Load.loadPotions();
                Load.loadMobs();

                ////Main Menu
                //Console.WriteLine("Are you new to Tarantino Observers?");
                //string userInput = Console.ReadLine();

                //if (userInput == "yes")
                //{
                //    //Introduction
                //    Introductions.WelcomeUser();
                //}
                //else if (userInput == "no")
                //{

                //}

                //else
                //{
                //    Console.WriteLine("I'm sorry, come again?");
                //}

                MovementMenu.UserMenu();

                //foreach (Room room in DemoWorld.rooms)
                //{
                //    Console.WriteLine(room.description);
                //}
                //Console.ReadLine();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
