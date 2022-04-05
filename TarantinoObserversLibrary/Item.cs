using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarantinoObserversLibrary
{
    public class Item
    {
        //Fields
        private int _id;
        private string _name;
        private string _description;
        private int _price;

        //constructor
        public Item()
        {
            _id = 0;
            _name = "";
            _description = "";
            _price = 0;
        }

        public Item(int id, string name, string description, int price)
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
