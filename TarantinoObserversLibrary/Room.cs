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
        private string _exits;

        //constructor
        public Room()
        {
            _id = 0;
            _name = "";
            _description = "";
            List<String> _exits = new List<String>();
        }

        public Room (int id, string name, string description)
        {
            _id = id;
            _name = name;
            _description = description;

        }

        //properties
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
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
