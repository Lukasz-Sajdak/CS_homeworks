using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2_polymorphism
{
    class Computer : Robot , IInternetUser
    {
        public bool InternetConnection { get; private set; }

        public Computer(bool _InternetConnection) : base("Computer")
        {
            InternetConnection = _InternetConnection;
        }

        public override int AnnualCost()
        {
            return 5000;
        }
    }
}
