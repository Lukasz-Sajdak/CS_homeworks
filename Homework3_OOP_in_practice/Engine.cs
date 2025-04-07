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
            return tank.Weight >= travelTime/100;
        }
        public void Travel(double travelTime)
        {
            double fuelUsed = Math.Min(tank.Weight, travelTime);

            tank.Weight -= fuelUsed;
            waste.Weight += fuelUsed;
        }
    }
}
