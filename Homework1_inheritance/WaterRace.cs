using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1_inheritance
{
    class WaterRace : Race
    {
        protected string waterType;
        protected float waterDepth; //meters
        protected float waterTemperature; // °C

        public WaterRace() { }

        public WaterRace(string _raceName, string _location, float _distance, string _waterType, float _waterDepth, float _waterTemperature) : base(_raceName, _location, _distance)
        {
            waterType = _waterType;
            waterDepth = _waterDepth;
            waterTemperature = _waterTemperature;
        }

        public void WaterRaceInfo()
        {
            RaceInfo();
            Console.WriteLine($"Water Type: {waterType}\n" +
                $"Water Depth: {waterDepth} m\n" +
                $"Water Temperature: {waterTemperature}\u00B0C");
        }
    }
}
