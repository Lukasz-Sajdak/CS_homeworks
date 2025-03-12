using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1_inheritance
{
    class Swimming : WaterRace
    {
        protected string swimmingStyle;

        public Swimming () { }

        public Swimming(string _raceName, string _location, float _distance, string _waterType, float _waterDepth, float _waterTemperature, string _swimmingStyle) 
        : base(_raceName, _location, _distance, _waterType, _waterDepth, _waterTemperature)
        {
            swimmingStyle = _swimmingStyle;
        }

        public void SwimmingInfo()
        {
            WaterRaceInfo();
            Console.WriteLine($"Swimming Style: {swimmingStyle}");
        }
    }
}
