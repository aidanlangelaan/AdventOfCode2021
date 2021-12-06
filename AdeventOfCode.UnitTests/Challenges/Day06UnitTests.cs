using AdventOfCode.Challenges;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdeventOfCode.UnitTests.Challenges
{
    [TestClass]
    public class Day06UnitTests
    {
        private Day06 day06;

        [TestInitialize]
        public void SetupTests()
        {
            var testInput = new[]
            {
                3,4,3,1,2
            };

            day06 = new Day06(testInput);
        }

        [TestMethod]
        public void Example_Part1_ShouldReturn5934()
        {
            // act
            var result = day06.SolvePart1();

            // assert
            Assert.AreEqual(5934, result);
        }

        //[TestMethod]
        //public void Example_Part2_ShouldReturn12()
        //{
        //    // act
        //    var result = day06.SolvePart2();

        //    // assert
        //    Assert.AreEqual(12, result);
        //}
    }
}
