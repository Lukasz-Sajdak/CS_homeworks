using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5_Abstract_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            InteriorDesigner[] designers = new InteriorDesigner[]
            {
            new ClassicInteriorDesigner(),
            new ModernInteriorDesigner(),
            new ScandinavianInteriorDesigner(),
            new VintageInteriorDesigner(),
            };

            int[] priceLevels = new int[] { 300, 500, 800 };

            foreach (var designer in designers)
            {
                Console.WriteLine($"--- Designer: {designer.GetType().Name}  ---\n");
                foreach (int price in priceLevels)
                {
                    var desk = designer.ProduceDesk(price);
                    var wardrobe = designer.ProduceWardrobe(price);

                    Console.WriteLine($"Price Limit: {price}");
                    Console.WriteLine("Desk: " + (desk != null ? desk.ToString() : "Not available"));
                    Console.WriteLine("Wardrobe: " + (wardrobe != null ? wardrobe.ToString() : "Not available"));
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
        }
    }
}
