using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    internal class Scientist : Human
    {
        private Equipment equipment;

        public Scientist() { }

        public Scientist (Equipment _equipment)
        {
            equipment = _equipment;
        }

        public void Work(double time)
        {

        }
    }
}
