using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2_polymorphism
{
    class Computer : Robot
    {
        public Computer() : base("Computer"){ }

        public override int AnnualCost()
        {
            return 5000;
        }
    }
}
