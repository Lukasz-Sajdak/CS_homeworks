using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6_strategy
{
    class StrategyFollower : IStrategy
    {
        public bool GetNextMove(List<bool> knownMoves)
        {
            if (knownMoves.Count == 0)
                return true;
            return knownMoves[knownMoves.Count - 1];
        }
    }
}
