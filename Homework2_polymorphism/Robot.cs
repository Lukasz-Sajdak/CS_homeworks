using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Homework2_polymorphism
{
    abstract class Robot
    {
        protected string type;
        protected string model;

        public Robot(string _type, string _model)
        {
            type = _type;
            model = _model;
        }

        public string Model => model;

        public abstract int AnnualCost();
    }
}
