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
            List<Robot> robots = new List<Robot>()
            {
                new Computer("xxx",true),
                new Computer("yyy", false),
                new MechanicalRobot("zzz")
            };

            List<Human> humans = new List<Human>()
            {
                new OfficeWorker("John",true),
                new OfficeWorker("Tom",false),
                new PhysicalWorker("Billy")
            };

            List<IInternetUser> internetUsers = new List<IInternetUser>();

            foreach (Robot robot in robots)
            {
                if (robot is IInternetUser internetRobot)
                    internetUsers.Add(internetRobot);
            }

            foreach (Human human in humans)
            {
                if(human is IInternetUser internetHuman)
                    internetUsers.Add(internetHuman);
            }

            int totalRobotCosts = 0;
            foreach (Robot robot in robots)
            {
                totalRobotCosts += robot.AnnualCost();
            }
            Console.WriteLine($"Total annual robot maintenance costs:: {totalRobotCosts}");

            float totalHumanCosts = 0;
            foreach (Human human in humans)
            {
                totalHumanCosts += human.Cost(12);
            }
            Console.WriteLine($"Total annual employment costs: {totalHumanCosts}\n");

            foreach (IInternetUser internetUser in internetUsers)
            {   
                if (internetUser is Human human)
                    Console.WriteLine($"- {human.Name}: {(internetUser.InternetConnection ? "Connected" : "No connection")}");
                else if (internetUser is Robot robot)
                    Console.WriteLine($"- {robot.Model}: {(internetUser.InternetConnection ? "Connected" : "No connection")}");
            }

            Console.ReadKey();
        }
    }
}
