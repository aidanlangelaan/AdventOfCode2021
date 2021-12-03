using AdventOfCode.Challenges;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdeventOfCode.UnitTests.Challenges
{
    [TestClass]
    public class Day03UnitTests
    {
        private Day03 day03;

        [TestInitialize]
        public void SetupTests()
        {
            var testInput = new[]
            {
                "00100","11110","10110","10111","10101","01111","00111","11100","10000","11001","00010","01010"
            };

            day03 = new Day03(testInput);
        }

        [TestMethod]
        public void Example_Part1_ShouldReturn198()
        {
            // act
            var result = day03.SolvePart1();

            // assert
            Assert.AreEqual(198, result);
        }

        [TestMethod]
        public void Example_Part2_ShouldReturn230()
        {
            // act
            var result = day03.SolvePart2();

            // assert
            Assert.AreEqual(230, result);
        }
    }
}
