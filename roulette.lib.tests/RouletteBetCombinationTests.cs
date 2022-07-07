using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace roulette.lib.tests
{
    public class RouletteBetCombinationTests
    {
        
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Split100into10parts()
        {
            int minBet = 1;
            int maxBet = 10;
            int totalBet = 100;
            int betCount = 6;
            RouletteBetCombination combination = new RouletteBetCombination(minBet, maxBet, totalBet);

        }
    }
}
