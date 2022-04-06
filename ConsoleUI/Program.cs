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
                //Introduction
                Introductions.WelcomeUser();

                //Main Menu
                MovementMenu.UserMenu();

                Room myRoom = new Room();
                Room yourRoom = new Room(501, "Entrance", "The entrance to this castle is battered. Maybe from a battle long passed. Amidst the rubble lies broken swords, tattered armor, and shattered frames. By the looks of undamaged " +
                    "weapons piled in the corner of the entrance, you may not be the first one here…and definitely not the last…");
                Console.WriteLine(yourRoom.name);
                Console.WriteLine(yourRoom.description);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
