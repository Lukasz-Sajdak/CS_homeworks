using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2_polymorphism
{
    class PhysicalWorker : Human
    {

        public PhysicalWorker(string _name) : base(4000f, _name) { }

        public override float Cost(int months)
        {
            return months * salary;
        }
    }
}
