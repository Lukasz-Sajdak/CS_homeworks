using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    internal abstract class Fuel : FuelTank, ITransportable
    {
        public string Type { get; }
        protected double density;

        public Fuel(string _type, double _density, double _maxCapacity, Fuel fuel)
            :base(_maxCapacity, fuel)
        {
            Type = _type;
            density = _density;
        }


    }
}
