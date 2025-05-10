using System;
using System.Collections.Generic;
namespace Homework7_commands
{
    public class Program
    {
        public static void Main()
        {
            Museum museum = new Museum();
            Restaurant restaurant = new Restaurant();
            Park park = new Park();
            SouvenirShop shop = new SouvenirShop();

            TripScheduler scheduler = new TripScheduler();

            Console.WriteLine("Scenariusz 1:");
            scheduler.AddVisit(new VisitMuseumCommand(museum, "10:00", 20));
            scheduler.AddVisit(new VisitParkCommand(park, 30, "słonecznie"));
            scheduler.AddVisit(new VisitRestaurantCommand(restaurant, "Pizza", 60));
            scheduler.Trip();
            scheduler.ClearSchedule();

            Console.WriteLine("Scenariusz 2:");
            scheduler.AddVisit(new VisitRestaurantCommand(restaurant, "Makaron", 45));
            scheduler.AddVisit(new VisitSouvenirShopCommand(shop, "Magnes", 10));
            scheduler.AddVisit(new VisitMuseumCommand(museum, "13:30", 25));
            scheduler.Trip();
            scheduler.ClearSchedule();

            Console.WriteLine("Scenariusz 3:");
            scheduler.AddVisit(new VisitParkCommand(park, 60, "pochmurno"));
            scheduler.AddVisit(new VisitSouvenirShopCommand(shop, "Koszulka", 50));
            scheduler.AddVisit(new VisitRestaurantCommand(restaurant, "Zupa", 30));
            scheduler.AddVisit(new VisitMuseumCommand(museum, "15:00", 30));
            scheduler.Trip();
        }
    }
}