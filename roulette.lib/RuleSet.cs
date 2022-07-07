using System;
using System.Collections.Generic;

namespace roulette.lib
{
    public class RuleSet
    {        
        private RuleTypes _type;

        private int _bet;

        private Dictionary<RuleTypes,int> Rewards = new Dictionary<RuleTypes, int>(){
            {RuleTypes.First2to1 , 3},
            {RuleTypes.Second2to1 , 3},
            {RuleTypes.Third2to1 , 3},
            {RuleTypes.Red , 2},
            {RuleTypes.Black , 2},
            {RuleTypes.Odd , 2},
            {RuleTypes.Even , 2},
            {RuleTypes.One2Eighteen , 2},
            {RuleTypes.Nineteen2Thirtysix , 2},
            {RuleTypes.First12 , 2},
            {RuleTypes.Second12 , 2},
            {RuleTypes.Third12 , 2}
        };

       

        public RuleSet(RuleTypes type , int bet)
        {
            _type = type;
            _bet = bet;
        }

         internal Dictionary<int, int> WinningNumbers()
        {
            Dictionary<int, int> numbers = new Dictionary<int, int>();
            for (int i = 0; i <= 36; i++)
            {
                int result = 0;
                if(Contains(_type, i)){
                    result = (Rewards[_type] * _bet) - _bet;                    
                }
                else{
                    result = -1 * _bet;                    
                }

                numbers.Add(i, result);

                Console.WriteLine("{0}->{1}", i, result);
                
            }
            return numbers;
        }

        private bool Contains(RuleTypes type, int i)
        {
            return ComninationNumbers[type].Contains(i);
        }

        private Dictionary<RuleTypes, List<int>> ComninationNumbers = new Dictionary<RuleTypes, List<int>>{
            {RuleTypes.First2to1 , new List<int> { 3, 6, 9, 12, 15, 18, 21, 24, 27, 30 , 33, 36}},
            {RuleTypes.Second2to1 , new List<int> { 2,5,8,11,14,17,20,23,26,29,32,35}},
            {RuleTypes.Third2to1 , new List<int> { 1,4,7,10,13,16,19,22,25,28,31,34}},
            {RuleTypes.Red , new List<int> { 1, 3, 5, 7, 9 , 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32,34,36}},
            {RuleTypes.Black , new List<int> { 2,4,6,8,10,13,15,17,20,22,24,26,28,29,31,33,35}},
            {RuleTypes.Odd , new List<int> { 1, 3, 5, 7, 9 , 11, 13, 15, 19, 21, 23, 25, 27, 29, 31, 32,35}},
            {RuleTypes.Even , new List<int> { 2,4,6,8,10,12,14,16,18,20,22,24,26,28,30,32,34,36} },
            {RuleTypes.First12 , new List<int> { 1,2,3,4,5,6,7,8,9,10,11,12} },
            {RuleTypes.Second12 , new List<int> { 13,14,15,16,17,18,19,20,21,22,23,24} },
            {RuleTypes.Third12 , new List<int> { 25,26,27,28,29,30,31,32,33,34,35,36} },
            {RuleTypes.One2Eighteen , new List<int> { 1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18} },
            {RuleTypes.Nineteen2Thirtysix , new List<int> { 19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36} },


        };
    }

}
