using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class LifeSupportSystem
    {
        private List<OxygenBottle> oxygenBottles;
        private FoodContainer foodContainer;
        private Waste waste;
        private List<Human> crew;

        public LifeSupportSystem(List<OxygenBottle> _bottles, FoodContainer _container, Waste _waste,List<Human> _crew) 
        {
            oxygenBottles = _bottles;
            foodContainer = _container;
            waste = _waste;
            crew = _crew;
        }
        public bool CheckSuppliesBeforeTravel(double timeTravel) {

            double oxygenNeeded = crew.Count * timeTravel;
            double foodNeeded = crew.Count * timeTravel;
            double totalOxygenAvailable = oxygenBottles.Sum(bottle => bottle.Weight);

            return totalOxygenAvailable >= oxygenNeeded &&
                   foodContainer.Weight >= foodNeeded;

        }
        public void Run(double timeTravel) 
        {
            double totalOxygenNeeded = crew.Count * timeTravel;
            double totalFoodNeeded = crew.Count * timeTravel;

            foreach (OxygenBottle bottle in oxygenBottles) 
            {
                double consumed = Math.Min(bottle.Weight, totalOxygenNeeded);
                bottle.Weight -= consumed;
                totalOxygenNeeded -= consumed;
            }
            foodContainer.Weight = Math.Max(0, foodContainer.Weight - totalFoodNeeded);
            waste.Weight += totalFoodNeeded;
        }
    }
}
