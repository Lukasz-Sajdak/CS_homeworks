using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1_inheritance
{
    class Cycling : LandRace
    {
        private string bikeType;

        public Cycling() { }

        public Cycling(string _raceName, string _location, float _distance, string _surfaceType, float _temperature, string _bikeType) : base(_raceName, _location, _distance, _surfaceType, _temperature)
        {
            bikeType = _bikeType;
        }

        public void CyclingInfo()
        {
            LandRaceInfo();
            Console.WriteLine($"Bike Type: {bikeType}");
        }
    }
}
