using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarantinoObserversLibrary
{
    public class Mob
    {
        //Fields
        private string _id;
        private string _name;
        private string _race;
        private string _class;
        private string _hp;
        private string _ap;
        private string _weapon;
        private string _inventory;
        private string _description;

        //constructor
        public Mob()
        {
            _id = " ";
            _name = " ";
            _race = " ";
            _class = " ";
            _hp = " ";
            _ap = " ";
            _weapon = " ";
            _inventory = " ";
            _description = " ";
        }

        public Mob(string id, string name, string race, string Class, string hp, string ap, string weapon, string inventory, string description)
        {
            _id = id;
            _name = name;
            _race = race;
            _class = Class;
            _hp = hp;
            _ap = ap;
            _weapon = weapon;
            _inventory = inventory;
            _description = description;
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
        public string description
        {
            get { return _description; }
            set { _description = value; }
        }
        public string race
        {
            get { return _race; }
            set { _id = value; }
        }

        public string Class
        {
            get { return _class; }
            set { _name = value; }
        }
        public string hp
        {
            get { return _hp; }
            set { _description = value; }
        }
        public string ap
        {
            get { return _ap; }
            set { _id = value; }
        }

        public string weapon
        {
            get { return _weapon; }
            set { _name = value; }
        }
        public string inventory
        {
            get { return _inventory; }
            set { _description = value; }
        }
        //methods

    }
}
