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
            _name = "";
            _race = "";
            _class = "";
            _hp = " ";
            _ap = " ";
            _weapon = "";
            _inventory = "";
            _description = "";
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

        //methods
    }
}
