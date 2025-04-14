using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5_Abstract_Factory
{
    abstract class Desk
    {
        public int price { get; }
        public string shape { get; }

        public Desk(int _price, string _shape)
        {
            price = _price;
            shape = _shape;
        }

        public abstract override string ToString();
    }
}
