using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2_polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Robot r1 = new Computer(true);
            Robot r2 = new MechanicalRobot();

            Console.WriteLine(r1.AnnualCost());
            Console.WriteLine(r2.AnnualCost());

            Human h1 = new PhysicalWorker();
            Human h2 = new OfficeWorker(true);

            Console.WriteLine(h1.Cost(2));
            Console.WriteLine(h2.Cost(3));

        }
    }
}
