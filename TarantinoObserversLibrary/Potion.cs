using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarantinoObserversLibrary
{
    public class Potion
    {
        //Fields
        private string _id;
        private string _name;
        private string _price;
        private string _valueChange;
        private string _description;

        //constructor
        public Potion()
        {
            _id = " ";
            _name = "";
            _price = " ";
            _valueChange = " ";
            _description = " ";
        }

        public Potion (string id, string name, string description, string price, string valueChange)
        {
            _id = id;
            _name = name;
            _price = price;
            _valueChange = valueChange;
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
        public string price
        {
            get { return _price; }
            set { _id = value; }
        }

        public string valueChange
        {
            get { return _valueChange; }
            set { _name = value; }
        }

        //methods
    }
}