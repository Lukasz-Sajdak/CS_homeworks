﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class OxygenBottle : IVisitPort
    {
        public double MaxCapacity { get; set; }
        protected double volume, weight;
        public double Volume
        {
            get { return volume; }
            set
            {
                volume = MaxCapacity;
                weight = value * 7.0; // assume density equal to 7000 kg/m^3 (arbitrary number)
            }
        }
        public double Weight
        {
            get { return weight; }
            set
            {
                weight = value;
                volume = value / 7.0; // assume density equal to 7000 kg/m^3 (arbitrary number)
            }
        }

        public OxygenBottle(double _maxCapacity)
        {
            MaxCapacity = _maxCapacity;
        }
        public double VisitPort()
        {
            double refillAmount = MaxCapacity - Volume;
            Volume = MaxCapacity;
            return refillAmount * 50;
        }
    }
}
