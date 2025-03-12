using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1_inheritance
{
    class LandRace : Race
    {
        protected string surfaceType; 
        protected float temperature; // °C

        public LandRace() { }

        public LandRace(string _raceName, string _location, float _distance, string _surfaceType, float _temperature) : base(_raceName,_location, _distance)
        {
            surfaceType = _surfaceType;
            temperature = _temperature;
        }

        public void LandRaceInfo()
        {
            RaceInfo();
            Console.WriteLine($"Surface Type: {surfaceType}\n" +
                $"Temperature: {temperature}\u00B0C");
        }
    }
}
