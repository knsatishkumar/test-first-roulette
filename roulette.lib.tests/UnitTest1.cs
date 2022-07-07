using System;
using System.Collections.Generic;
using NUnit.Framework;
using roulette.lib;
namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void First2to1()
        {
            RoulettePermutation permutation = new RoulettePermutation();
            RuleSet set = new RuleSet(RuleTypes.First2to1 , 10);
            List<RuleSet> sets = new List<RuleSet>();
            sets.Add(set);
            var combinations = permutation.Calculate(sets);
            foreach (var item in combinations.Keys)
            {
                Console.WriteLine("{0}->{1}" , item , combinations[item]);
            }
            Assert.AreEqual(20, combinations[3]);
            Assert.AreEqual(-10, combinations[0]);
        }

        [Test]
        public void RedColor()
        {
            RoulettePermutation permutation = new RoulettePermutation();
            RuleSet set = new RuleSet(RuleTypes.Red, 10);
            List<RuleSet> sets = new List<RuleSet>();
            sets.Add(set);
            var combinations = permutation.Calculate(sets);
            foreach (var item in combinations.Keys)
            {
                Console.WriteLine("{0}->{1}", item, combinations[item]);
            }
            Assert.AreEqual(10, combinations[1]);
            Assert.AreEqual(-10, combinations[0]);
        }

        [Test]
        public void First2to1_RedColor()
        {
            RoulettePermutation permutation = new RoulettePermutation();
            RuleSet set1 = new RuleSet(RuleTypes.Red, 10);
            RuleSet set2 = new RuleSet(RuleTypes.First2to1, 10);
            List<RuleSet> sets = new List<RuleSet>();
            sets.Add(set1);
            sets.Add(set2);

            var combinations = permutation.Calculate(sets);
            foreach (var item in combinations.Keys)
            {
                Console.WriteLine("{0}->{1}", item, combinations[item]);
            }
            Assert.AreEqual(30, combinations[3]);
            Assert.AreEqual(-20, combinations[0]);
        }

        [Test]
        public void Combination1()
        {
            RoulettePermutation permutation = new RoulettePermutation();
            RuleSet set1 = new RuleSet(RuleTypes.Red, 20);
            RuleSet set2 = new RuleSet(RuleTypes.First2to1, 10);
            RuleSet set3 = new RuleSet(RuleTypes.Second2to1, 10);
            RuleSet set4 = new RuleSet(RuleTypes.Third2to1, 10);
            RuleSet set5 = new RuleSet(RuleTypes.Odd, 20);
            RuleSet set6 = new RuleSet(RuleTypes.One2Eighteen, 20);
            RuleSet set7 = new RuleSet(RuleTypes.Nineteen2Thirtysix, 20);
            List<RuleSet> sets = new List<RuleSet>();
            sets.Add(set1);
            sets.Add(set2);
            sets.Add(set3);
            sets.Add(set4);
            sets.Add(set5);
            sets.Add(set6);
            sets.Add(set7);

            var combinations = permutation.Calculate(sets);
            foreach (var item in combinations.Keys)
            {
                Console.WriteLine("{0}->{1}", item, combinations[item]);
            }
            Assert.AreEqual(40, combinations[1]);
            Assert.AreEqual(-40, combinations[2]);
            Assert.AreEqual(0, combinations[11]);
        }

        [Test]
        public void Combination2()
        {
            RoulettePermutation permutation = new RoulettePermutation();
            RuleSet set1 = new RuleSet(RuleTypes.Red, 20);
            RuleSet set2 = new RuleSet(RuleTypes.First2to1, 10);
            RuleSet set3 = new RuleSet(RuleTypes.Second2to1, 10);
            RuleSet set4 = new RuleSet(RuleTypes.Third2to1, 0);
            RuleSet set5 = new RuleSet(RuleTypes.Odd, 20);
            RuleSet set6 = new RuleSet(RuleTypes.One2Eighteen, 20);
            RuleSet set7 = new RuleSet(RuleTypes.Nineteen2Thirtysix, 20);
            List<RuleSet> sets = new List<RuleSet>();
            sets.Add(set1);
            sets.Add(set2);
            sets.Add(set3);
            sets.Add(set4);
            sets.Add(set5);
            sets.Add(set6);
            sets.Add(set7);

            var combinations = permutation.Calculate(sets);
            foreach (var item in combinations.Keys)
            {
                Console.WriteLine("{0}->{1}", item, combinations[item]);
            }
            Assert.AreEqual(-30, combinations[2]);
            Assert.AreEqual(50, combinations[3]);
            Assert.AreEqual(10, combinations[11]);
        }

        [Test]
        public void Combination3()
        {
            RoulettePermutation permutation = new RoulettePermutation();
            RuleSet set1 = new RuleSet(RuleTypes.Black, 0);
            RuleSet set2 = new RuleSet(RuleTypes.First2to1, 20);
            RuleSet set3 = new RuleSet(RuleTypes.Second2to1, 20);
            RuleSet set4 = new RuleSet(RuleTypes.Third2to1, 00);
            RuleSet set5 = new RuleSet(RuleTypes.Odd, 0);
            RuleSet set6 = new RuleSet(RuleTypes.One2Eighteen, 00);
            RuleSet set7 = new RuleSet(RuleTypes.Nineteen2Thirtysix, 00);
            RuleSet set8 = new RuleSet(RuleTypes.First12, 20);
            RuleSet set9 = new RuleSet(RuleTypes.Second12, 20);
            RuleSet set10 = new RuleSet(RuleTypes.Third12, 20);
            List<RuleSet> sets = new List<RuleSet>();
            sets.Add(set1);
            sets.Add(set2);
            sets.Add(set3);
            sets.Add(set4);
            sets.Add(set5);
            sets.Add(set6);
            sets.Add(set7);
            sets.Add(set8);
            sets.Add(set9);
            sets.Add(set10);

            var combinations = permutation.Calculate(sets);
            foreach (var item in combinations.Keys)
            {
                Console.WriteLine("{0}->{1}", item, combinations[item]);
            }
            //Assert.AreEqual(-30, combinations[2]);
            //Assert.AreEqual(50, combinations[3]);
            //Assert.AreEqual(10, combinations[11]);
        }
    }
}