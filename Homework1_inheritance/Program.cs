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
            Race race = new Race("Race", "Cracow", 225.8f);
            race.RaceInfo();

            LandRace landRace = new LandRace("Land Race", "Warsaw", 50, "Ground", 20.5f);
            landRace.LandRaceInfo();

            WaterRace waterRace = new WaterRace("Water Race", "London", 5, "fresh water", 20.5f, 22.1f);
            waterRace.WaterRaceInfo();

            Running running = new Running("10km Run", "Otwock", 10, "Ground", 26.2f, true);
            running.RunningInfo();

            Cycling cycling = new Cycling("Tour de France", "France", 3498f, "Asphalt", 26.2f, "Racing Bike");
            cycling.CyclingInfo();
            //cycling.LandRaceInfo();
            //cycling.RaceInfo();

            Swimming swimming = new Swimming("2km Swimming", "Paris", 2, "fresh water", 20.5f, 40f , "Medley");
            swimming.SwimmingInfo();

        }
    }
}
