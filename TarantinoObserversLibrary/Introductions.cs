using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TarantinoObserversLibrary
{
    public class Introductions
    {
        public static void WelcomeUser()
        {
            //Declaring variables
            StreamWriter outputFile;

            //Getting player information
            outputFile = File.CreateText("Observer_Cirtificate.txt");
            Console.WriteLine("Greetings, Observer!");
            Console.WriteLine("What is your name? >");
            string nameInput = Console.ReadLine();
            outputFile.WriteLine("Observer name:" + nameInput);

            Console.WriteLine(nameInput + ". A name that will ring across the land!");
            Console.WriteLine("This is your observer handbook. Create a password so that only you may access it's contents. >");
            string passwordInput = Console.ReadLine();
            outputFile.WriteLine("Your password is: " + passwordInput);
            Console.WriteLine("Keep that password safe, okay?");
            Console.WriteLine("Finally, what class of Observer are you? A (Gunslinger), (Witch), or (standard)? >");
            string classInput = Console.ReadLine();
            outputFile.WriteLine("Your Class is:" + classInput);

            Console.WriteLine("Finalized! You are now officially an Observer of the Tarantino Family! Now get out there and observe some monsters!");
            Console.WriteLine("Remember! Communication amongst monsters is key!");
            outputFile.Close();
        }
    }
}
