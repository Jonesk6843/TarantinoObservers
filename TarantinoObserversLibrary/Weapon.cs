using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarantinoObserversLibrary
{
    public class Weapon
    {
        //Fields
        private string _id;
        private string _name;
        private string _description;
        private string _damageType;
        private string _price;
        private string _damage;

        //constructor
        public Weapon()
        {
            _id = " ";
            _name = "";
            _description = "";
            _damageType = "";
            _price = " ";
            _damage = " ";
        }

        public Weapon(string id, string name, string description, string damageType, string price, string damage)
        {
            _id = id;
            _name = name;
            _description = description;
            _damageType = damageType;
            _price = price;
            _damage = damage;
        }

        //properties

        //methods
    }
}
