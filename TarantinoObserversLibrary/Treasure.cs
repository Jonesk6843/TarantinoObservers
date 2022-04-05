using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarantinoObserversLibrary
{
    public class Treasure
    {
        //Fields
        private int _id;
        private string _name;
        private string _description;
        private int _price;

        //constructor
        public Treasure()
        {
            _id = 0;
            _name = "";
            _description = "";
            _price = 0;
        }

        public Treasure(int id, string name, string description, int price)
        {
            _id = id;
            _name = name;
            _description = description;
            _price = price;
        }
        //properties

        //methods
    }
}