using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    internal class FuelTank : IVisitPort
    {
        public double MaxCapacity { get; set; }
        private Fuel fuel;

        protected double volume, weight;
        public double Volume
        {
            get { return volume; }
            set
            {
                volume = MaxCapacity;
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

        public FuelTank(double _maxCapacity, Fuel _fuel)
        {
            MaxCapacity = _maxCapacity;
            fuel = _fuel;
        }

        public string GetFuelType()
        {
            return fuel.GetType();
        }

        public double VisitPort()
        {
            return 0;
        }
    }
}
