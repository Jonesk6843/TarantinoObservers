using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarantinoObserversLibrary
{
    public class Room
    {
        //Fields
        private int _id;
        private string _name;
        private string _description;

        //constructor
        public Room()
        {
            _id = 0;
            _name = "";
            _description = "";
        }

        public Room (int id, string name, string description)
        {
            _id = id;
            _name = name;
            _description = description;
        }

        //properties
        public string description
        {
            get { return _description; }
            set { _description = value; }
        }

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
        //methods
    }
}
