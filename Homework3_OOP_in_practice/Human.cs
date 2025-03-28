﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    public abstract class Human : ITransportable
    {
        protected double volume, weight;
        public double Volume
        {
            get { return volume; }
            set
            {
                volume = value;
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

        public Human() { }
        public Human(double _volume, double _weight)
        {
            Volume = _volume;
            Weight = _weight;
        }
    }
}
