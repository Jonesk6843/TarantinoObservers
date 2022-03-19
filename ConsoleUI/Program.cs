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
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
