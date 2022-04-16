using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TarantinoObserversLibrary
{
    public static class Load
    {
        public static void loadRoom()
        {
            bool firstLine = true;
            using (StreamReader reader = File.OpenText(@"C:\Users\Parker Pawn\source\repos\TarantinoObservers\TarantinoObserversLibrary\LoadFiles\Rooms.csv"))
            while (!reader.EndOfStream)
            {
                    string[] tokens = reader.ReadLine().Split(',');
                    if (firstLine != true)
                    {
                        //Tokens in order (ID, Name, Description)
                        DemoWorld.rooms.Add(new Room(tokens[0], tokens[1], tokens[2]));
                    }
                    else
                    {
                        firstLine = false;
                    }
            }
            
        }
    }
}
