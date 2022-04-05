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
        private int _id;
        private string _name;
        private string _description;
        private string _damageType;
        private int _price;
        private int _damage;

        //constructor
        public Weapon()
        {
            _id = 0;
            _name = "";
            _description = "";
            _damageType = "";
            _price = 0;
            _damage = 0;
        }

        public Weapon(int id, string name, string description, string damageType, int price, int damage)
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
