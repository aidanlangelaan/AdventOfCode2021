using AdventOfCode.Challenges;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdeventOfCode.UnitTests.Challenges
{
    [TestClass]
    public class Day05UnitTests
    {
        private Day05 day05;

        [TestInitialize]
        public void SetupTests()
        {
            var testInput = new[]
            {
                "0,9 -> 5,9","8,0 -> 0,8","9,4 -> 3,4","2,2 -> 2,1","7,0 -> 7,4","6,4 -> 2,0","0,9 -> 2,9","3,4 -> 1,4","0,0 -> 8,8","5,5 -> 8,2"
            };

            day05 = new Day05(testInput);
        }

        [TestMethod]
        public void Example_Part1_ShouldReturn5()
        {
            // act
            var result = day05.SolvePart1();

            // assert
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void Example_Part2_ShouldReturn12()
        {
            // act
            var result = day05.SolvePart2();

            // assert
            Assert.AreEqual(12, result);
        }
    }
}
