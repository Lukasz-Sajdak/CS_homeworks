using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7_commands
{
    public interface IVisitTouristAttraction
    {
        void Visit();
    }

    public class VisitMuseumCommand : IVisitTouristAttraction
    {
        private readonly Museum museum;
        private readonly string hour;
        private readonly int ticketPrice;

        public VisitMuseumCommand(Museum _museum, string _hour, int _ticketPrice)
        {
            museum = _museum;
            hour = _hour;
            ticketPrice = _ticketPrice;
        }

        public void Visit()
        {
            museum.WatchExhibits(hour, ticketPrice);
        }
    }

    public class VisitRestaurantCommand : IVisitTouristAttraction
    {
        private readonly Restaurant restaurant;
        private readonly string dish;
        private readonly int duration;

        public VisitRestaurantCommand(Restaurant _restaurant, string _dish, int _duration)
        {
            restaurant = _restaurant;
            dish = _dish;
            duration = _duration;
        }

        public void Visit()
        {
            restaurant.EatMeal(dish, duration);
        }
    }

    public class VisitParkCommand : IVisitTouristAttraction
    {
        private readonly Park park;
        private readonly int minutes;
        private readonly string weather;

        public VisitParkCommand(Park _park, int _minutes, string _weather)
        {
            park = _park;
            minutes = _minutes;
            weather = _weather;
        }

        public void Visit()
        {
            park.TakeWalk(minutes, weather);
        }
    }

    public class VisitSouvenirShopCommand : IVisitTouristAttraction
    {
        private readonly SouvenirShop shop;
        private readonly string item;
        private readonly int price;

        public VisitSouvenirShopCommand(SouvenirShop _shop, string _item, int _price)
        {
            shop = _shop;
            item = _item;
            price = _price;
        }

        public void Visit()
        {
            shop.BuySouvenir(item, price);
        }
    }
}
