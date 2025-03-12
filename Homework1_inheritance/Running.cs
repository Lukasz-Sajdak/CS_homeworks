using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1_inheritance
{
    class Running : LandRace
    {
        private bool headphonesAllowed;

        public Running() { }

        public Running(string _raceName, string _location, float _distance, string _surfaceType, float _temperature, bool _headphonesAllowed) : base(_raceName, _location, _distance, _surfaceType, _temperature) 
        {
            headphonesAllowed = _headphonesAllowed;
        }

        public void RunningInfo()
        {
            LandRaceInfo();
            string allowed = headphonesAllowed == true ? "Yes" : "No";
            Console.WriteLine($"Are headphones allowed? : {allowed}");
        }
    }
}
