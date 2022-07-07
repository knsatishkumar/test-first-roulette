using System;
using System.Collections.Generic;

namespace roulette.lib
{
    public class RoulettePermutation
    {
        public Dictionary<int, int> Calculate(List<RuleSet> sets)
        {
            Dictionary<int, int> result = new Dictionary<int, int>();
            for (int i = 0; i <= 36; i++)
            {
                result.Add(i, 0);
            }
            foreach (var set in sets)
            {
                var dict = set.WinningNumbers();
                foreach (var key in dict.Keys)
                {
                    result[key] += dict[key];
                }
            }
            return result;
        }
    }
}
