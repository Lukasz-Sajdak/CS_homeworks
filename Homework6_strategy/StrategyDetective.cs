using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6_strategy
{
    class StrategyDetective : IStrategy
    {
        private int round = 0;

        public bool GetNextMove(List<bool> knownMoves)
        {
            round++;
            if (round == 1) return true;
            if (round == 2) return false;
            if (round == 3) return true;
            if (round == 4) return true;

            return knownMoves[knownMoves.Count - 1];
        }
    }
}
