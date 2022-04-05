using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarantinoObserversLibrary
{
    class Mob
    {
        //Fields
        private int _id;
        private string _name;
        private string _race;
        private string _class;
        private int _hp;
        private int _ap;
        private string _weapon;
        private string _inventory;
        private string _description;

        //constructor
        public Mob()
        {
            _id = 0;
            _name = "";
            _race = "";
            _class = "";
            _hp = 0;
            _ap = 0;
            _weapon = "";
            _inventory = "";
            _description = "";
        }

        public Mob(int id, string name, string race, string Class, int hp, int ap, string weapon, string inventory, string description)
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

        //methods
    }
}
