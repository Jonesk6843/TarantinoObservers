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
        private string _id;
        private string _name;
        private string _description;
        private string _price;
        private string _questItem;

        //constructor
        public Treasure()
        {
            _id = " ";
            _name = "";
            _description = "";
            _price = " ";
            _questItem = " ";
        }

        public Treasure(string id, string name, string description, string price, string questItem)
        {
            _id = id;
            _name = name;
            _description = description;
            _price = price;
            _questItem = questItem;
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
        public string price
        {
            get { return _price; }
            set { _price = value; }
        }

        //methods
    }
}