using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2_polymorphism
{
    abstract class Robot
    {
        protected string type;

        public Robot(string _type)
        {
            type = _type;
        }

        public abstract int AnnualCost();
    }
}
