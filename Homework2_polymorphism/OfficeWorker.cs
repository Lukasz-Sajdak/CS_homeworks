using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2_polymorphism
{
    class OfficeWorker : Human
    {
        public OfficeWorker():base(5000f) { }

        public override float Cost(int months)
        {
            return months * salary * 1.1f; //10% additional office maintence costs
        }
    }
}
