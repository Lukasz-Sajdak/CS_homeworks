using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Homework1_inheritance
{
    class OpenWaterSwimming : Swimming
    {
        private bool isLifeThreatening;
        private float salinityLevel; //per mille

        public OpenWaterSwimming() { }

        public OpenWaterSwimming(string _raceName, string _location, float _distance, string _waterType, float _waterDepth, float _waterTemperature, string _swimmingStyle,
            bool _isLifeThreatening, float _salinityLevel) 
            : base(_raceName, _location, _distance, _waterType, _waterDepth, _waterTemperature, _swimmingStyle)
        {
            isLifeThreatening = _isLifeThreatening;
            salinityLevel = _salinityLevel;
        }

        public void OpenWaterSwimmingInfo()
        {
            SwimmingInfo();
            string lifeThreatening = isLifeThreatening == true ? "Yes" : "No";
            Console.WriteLine($"Is this life threatening? : {lifeThreatening}\n" +
                $"Salinity: {salinityLevel}\u2030");
        }
    }
}
