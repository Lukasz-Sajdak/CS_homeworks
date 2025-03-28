using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class FoodContainer : IVisitPort
    {
        public double MaxCapacity { get; set; }

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

        public FoodContainer(double maxCapacity)
        {
            this.MaxCapacity = maxCapacity;
        }

        public double VisitPort()
        {
            double refillAmount = MaxCapacity - Volume;
            Volume = MaxCapacity;
            return refillAmount * 5;
        }
    }
}
