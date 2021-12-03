using AdventOfCode.Challenges;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdeventOfCode.UnitTests.Challenges
{
    [TestClass]
    public class Day01UnitTests
    {
        private Day01 day01;

        [TestInitialize]
        public void SetupTests()
        {
            var testInput = new[]
            {
                "199","200","208","210","200","207","240","269","260","263"
            };

            day01 = new Day01(testInput);
        }

        [TestMethod]
        public void Example_Part1_ShouldReturn7()
        {
            // act
            var result = day01.SolvePart1();

            // assert
            Assert.AreEqual(7, result);
        }

        [TestMethod]
        public void Example_Part2_ShouldReturn5()
        {
            // act
            var result = day01.SolvePart2();

            // assert
            Assert.AreEqual(5, result);
        }
    }
}
