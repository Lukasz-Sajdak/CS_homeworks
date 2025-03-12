using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1_inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Race race = new Race("IronMan", "Cracow", 225.8f);
            race.RaceInfo();

            LandRace landRace = new LandRace("Big Race", "Warsaw", 100, "ground", 20.5f);
            landRace.LandRaceInfo();

            WaterRace waterRace = new WaterRace("Water Race", "London", 5, "fresh water", 20.5f, 22.1f);
            waterRace.WaterRaceInfo();

            Running running = new Running("10km Run", "Otwock", 10, "ground", 26.2f, true);
            running.RunningInfo();

            Cycling cycling = new Cycling("Tour de France", "France", 3498f, "asphalt", 26.2f, "racing Bike");
            cycling.CyclingInfo();

            Swimming swimming = new Swimming("2km Swimming", "Paris", 2, "fresh water", 2f, 13.2f , "medley");
            swimming.SwimmingInfo();

            OpenWaterSwimming openWaterSwimming = new OpenWaterSwimming("4km Open Water", "Tokio", 4, "salt water", 15.2f, 4f, "medley", true, 35.2f);
            openWaterSwimming.OpenWaterSwimmingInfo();

            PoolSwimming poolSwimming = new PoolSwimming("200m Freestyle", "Sydney", 0.2f, "pool water", 4f, 22.5f, "freestyle", "indoor", 50);
            poolSwimming.PoolSwimmingInfo();

            //poolSwimming.SwimmingInfo();
            //poolSwimming.WaterRaceInfo();
            //poolSwimming.RaceInfo();

            Console.ReadKey();
        }
    }
}
