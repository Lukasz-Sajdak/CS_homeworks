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

        public Computer(string _model, bool _InternetConnection) : base("Computer", _model)
        {
            InternetConnection = _InternetConnection;
        }

        public override int AnnualCost()
        {
            return 5000;
        }
    }
}
