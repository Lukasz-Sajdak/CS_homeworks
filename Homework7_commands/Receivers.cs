using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7_commands
{
    public class Museum
    {
        public void WatchExhibits(string hour, int ticketPrice)
        {
            Console.WriteLine($"[Muzeum] Zwiedzanie o {hour}, cena biletu: {ticketPrice} PLN.");
        }
    }

    public class Restaurant
    {
        public void EatMeal(string dish, int duration)
        {
            Console.WriteLine($"[Restauracja] Zjedzono '{dish}', czas trwania: {duration} minut.");
        }
    }

    public class Park
    {
        public void TakeWalk(int minutes, string weather)
        {
            Console.WriteLine($"[Park] Spacer przez {minutes} minut, pogoda: {weather}.");
        }
    }

    public class SouvenirShop
    {
        public void BuySouvenir(string item, int price)
        {
            Console.WriteLine($"[Sklep] Kupiono: {item}, cena: {price} PLN.");
        }
    }
}
