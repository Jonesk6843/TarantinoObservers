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
        private int _id;
        private string _name;
        private int _price;
        private int _valueChange;

        //constructor
        public Potion()
        {
            _id = 0;
            _name = "";
            _price = 0;
            _valueChange = 0;
        }

        public Potion (int id, string name, int price, int valueChange)
        {
            _id = id;
            _name = name;
            _price = price;
            _valueChange = valueChange;
        }

        //properties

        //methods
    }
}