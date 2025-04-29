using System;
using System.Collections.Generic;
using System.Text;

namespace Homework6_strategy
{
    class StrategyAlwaysTrue : IStrategy
    {
        // placeholder strategy - always cooperate (always return true)
        public bool GetNextMove(List<bool> knownMoves)
        {
            return true;
        }
    }
}
