using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2_polymorphism
{
    class MechanicalRobot : Robot
    {
        public MechanicalRobot() : base("Mechanical Robot") { }

        public override int AnnualCost()
        {
            return 20000;
        }
    }
}
