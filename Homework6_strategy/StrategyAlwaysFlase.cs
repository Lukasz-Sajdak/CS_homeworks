using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6_strategy
{
    class StrategyAlwaysFalse : IStrategy
    {
        public bool GetNextMove(List<bool> knownMoves)
        {
            return false;
        }
    }
}
