using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6_strategy
{
    class StrategyRandom : IStrategy
    {
        private Random rnd = new Random();

        public bool GetNextMove(List<bool> knownMoves)
        {
            return rnd.NextDouble() >= 0.5;
        }
    }
}
