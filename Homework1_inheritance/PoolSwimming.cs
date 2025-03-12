using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1_inheritance
{
    class PoolSwimming : Swimming
    {
        private string poolType; 
        private int poolLength; //meters

        public PoolSwimming() { }

        public PoolSwimming(string _raceName, string _location, float _distance, string _waterType, float _waterDepth, float _waterTemperature, string _swimmingStyle,
            string _poolType, int _poolLength)
            : base(_raceName, _location, _distance, _waterType, _waterDepth, _waterTemperature, _swimmingStyle)
        {
            poolType = _poolType;
            poolLength = _poolLength;
        }

        public void PoolSwimmingInfo()
        {
            SwimmingInfo();
            Console.WriteLine($"Pool Type: {poolType}\n" +
                $"Pool Length: {poolLength} m");
        }
    }
}
