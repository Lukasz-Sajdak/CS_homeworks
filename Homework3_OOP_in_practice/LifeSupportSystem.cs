using System;
using System.Collections.Generic;
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
            if(oxygenBottles.Count == 0 || foodContainer.Weight == 0) return false;
            return true;
        }
        public void Run(double timeTravel) 
        {   
            foreach (OxygenBottle bottle in oxygenBottles) { bottle.Weight -= crew.Count * timeTravel; }
            foodContainer.Weight -= crew.Count * timeTravel;
            waste.Weight += crew.Count * timeTravel;
        }
    }
}
