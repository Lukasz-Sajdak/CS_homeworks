using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1_inheritance
{
    class Race
    {
        protected string raceName;
        protected string location;
        protected float distance;

        public Race() { }

        public Race(string _raceName, string _location, float _distance)
        {
            raceName = _raceName;
            location = _location;
            distance = _distance;
        }

        public void RaceInfo()
        {
            Console.WriteLine($"--->{raceName}<---\n" +
                $"Distance: {distance}\n" +
                $"Location: {location}");
        }
    }
}
