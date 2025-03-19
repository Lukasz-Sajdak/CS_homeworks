using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2_polymorphism
{
    class OfficeWorker : Human, IInternetUser
    {
        public bool InternetConnection { get; private set; }

        public OfficeWorker(string _name, bool _InternetConnection) :base(5000f, _name) 
        {
            InternetConnection = _InternetConnection;
        }

        public override float Cost(int months)
        {
            return months * salary * (InternetConnection ? 1.1f : 1);
        }
    }
}
