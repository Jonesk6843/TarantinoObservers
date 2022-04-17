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

        //methods
    }
}