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
        private string _id;
        private string _name;
        private string _password;
        private string _class;
        private int _hp;
        private int _ap;
        private string _location;
        private string _weapon;
        private string _inventory;
        private string _quests;

        //constructor
        public Player()
        {
            _id = " ";
            _name = "";
            _password = "";
            _class = "";
            _hp = 0;
            _ap = 0;
            _location = "";
            _weapon = " ";
            List<String> _inventory = new List<String>();
            _quests = "";
        }

        public Player(string id, string name, string password, string Class, int hp, int ap, string location, string weapon, string inventory, string quests)
        {
            _id = id;
            _name = name;
            _password = password;
            _class = Class;
            _hp = hp;
            _ap = ap;
            _location = location;
            _weapon = weapon;
            _inventory = inventory;
            _quests = quests;
        }

        //properties
        public string ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Class
        {
            get { return _class; }
            set { _class = value; }
        }
        public int hp
        {
            get {
                hp = 100;
                return _hp; }
            set { _hp = value; }
        }
        public int ap
        {
            get { 
                ap = 50;
                return _ap; }
            set { _ap = value; }
        }

        public string weapon
        {
            get { return _weapon; }
            set { _weapon = value; }
        }
        public string inventory
        {
            get { return _inventory; }
            set { _inventory = value; }
        }

        //methods
    }
}