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
        protected string name;

        public Human(float _salary, string _name) 
        {
            salary = _salary;
            name = _name;
        }
        public string Name => name;

        public abstract float Cost(int months);
    }
}
