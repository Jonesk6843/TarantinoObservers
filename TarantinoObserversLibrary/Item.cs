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
        private string _id;
        private string _name;
        private string _description;
        private string _price;
        private string _type;

        //constructor
        public Item()
        {
            _id = " ";
            _name = "";
            _description = "";
            _price = " ";
            _type = " ";
        }

        public Item(string id, string name, string description, string price, string type)
        {
            _id = id;
            _name = name;
            _description = description;
            _price = price;
            _type = type;
        }

        //properties

        //methods
    }
}
