using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6_strategy
{
    class StrategyGrudger : IStrategy
    {
        private bool hasBeenBetrayed = false;

        public bool GetNextMove(List<bool> knownMoves)
        {
            if (hasBeenBetrayed)
                return false;
            if (knownMoves.Contains(false))
                hasBeenBetrayed = true;
            return true;
        }
    }
}
