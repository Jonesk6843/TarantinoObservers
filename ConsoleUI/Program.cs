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
                //Main Menu
                Console.WriteLine("Are you new to Tarantino Observers?");
                string userInput = Console.ReadLine();

                if (userInput == "yes")
                {
                    //Introduction
                    Introductions.WelcomeUser();
                }
                else if (userInput == "no")
                {
                    //load file
                    LoadFiles.loadFile();
                }

                else
                {
                    Console.WriteLine("I'm sorry, come again?");
                }    

                MovementMenu.UserMenu();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
