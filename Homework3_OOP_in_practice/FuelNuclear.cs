using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    internal class FuelNuclear : Fuel
    {
        protected double volume, weight;

        public double Volume
        {
            get { return volume; }
            set
            {
                volume = value;
                weight = value * 7.0;
            }
        }
        public double Weight
        {
            get { return weight; }
            set
            {
                weight = value;
                volume = value / 7.0;
            }
        }
        public override string Type 
        { 
            get { return "nuclear"; } 
        }

        public override string GetType()
        {
            return Type;
        }
    }
}
