using System;
using System.Collections.Generic;
using System.Text;

namespace roulette.lib
{
    public class RouletteBetCombination
    {
        private int minBet;
        private int maxBet;
        private int totalBet;

        public RouletteBetCombination(int minBet, int maxBet, int totalBet)
        {
            this.minBet = minBet;
            this.maxBet = maxBet;
            this.totalBet = totalBet;
        }
    }
}
