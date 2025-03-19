using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2_polymorphism
{
    abstract class Human
    {
        protected float salary;

        public Human(float _salary) 
        {
            salary = _salary;
        }

        public abstract float Cost(int months);
    }
}
