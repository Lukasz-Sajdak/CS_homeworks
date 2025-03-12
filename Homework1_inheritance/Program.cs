using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1_inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Race ironman = new Race("IronMan", "Cracow", 225.8f);
            ironman.RaceInfo();
        }
    }
}
