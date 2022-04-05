using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarantinoObserversLibrary
{
    public class Player
    {
        //Fields
        private int _id;
        private string _name;
        private string _password;
        private string _class;
        private int _hp;
        private int _ap;
        private string _location;
        private string _inventory;
        private string _quests;

        //constructor
        public Player()
        {
            _id = 0;
            _name = "";
            _password = "";
            _class = "";
            _hp = 0;
            _ap = 0;
            _location = "";
            _inventory = "";
            _quests = "";
        }

        public Player(int id, string name, string password, string Class, int hp, int ap, string location, string inventory, string quests)
        {
            _id = id;
            _name = name;
            _password = password;
            _class = Class;
            _hp = hp;
            _ap = ap;
            _location = location;
            _inventory = inventory;
            _quests = quests;
        }

        //properties

        //methods
    }
}