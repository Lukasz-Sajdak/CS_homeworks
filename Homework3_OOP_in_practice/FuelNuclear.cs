using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    internal class FuelNuclear : Fuel
    {

        public FuelNuclear(string _type, double _density, double _maxCapacity, Fuel _fuel) 
            :base(_type, _density, _maxCapacity, _fuel) { }
    }
}
