using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    internal class FuelTank : IVisitPort
    {
        public double Volume { get; set; }
        public double Weight { get; set; }
        public double maxCapacity { get; }
        private Fuel fuel { get; }

        public FuelTank(double _maxCapacity, Fuel _fuel)
        {
            maxCapacity = _maxCapacity;
            fuel = _fuel;
        }
        public double VisitPort()
        {
            return 0;
        }
    }
}
