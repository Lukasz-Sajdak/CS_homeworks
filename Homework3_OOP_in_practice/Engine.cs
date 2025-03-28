using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Engine
    {
        private FuelTank tank;
        private Waste waste;

        public Engine (FuelTank _tank, Waste _waste)
        {
            tank = _tank;
            waste = _waste;
        }

        public double GetVelocity(double submarineWeight)
        {
            return submarineWeight / 400000;
        }
        public bool CheckFuelBeforeTravel(double travelTime)
        {
            if (tank.Weight == 0)
                return false;
            else 
                return true;
        }
        public void Travel(double travelTime)
        {
            tank.Weight -= travelTime;
            waste.Weight += travelTime;
        }
    }
}
