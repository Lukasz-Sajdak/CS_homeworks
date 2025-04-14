using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5_Abstract_Factory
{
    abstract class Wardrobe
    {
        public int price { get; }
        public string color { get; }

        public Wardrobe(int _price, string _color)
        {
            price = _price;
            color = _color;
        }

        public abstract override string ToString();
    }
}
