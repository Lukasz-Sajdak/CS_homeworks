using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2_polymorphism
{
    class PhysicalWorker : Human
    {

        public PhysicalWorker() : base(4000f) { }

        public override float Cost(int months)
        {
            return months * salary;
        }
    }
}
