using AdventOfCode.Challenges;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdeventOfCode.UnitTests.Challenges
{
    [TestClass]
    public class Day02UnitTests
    {
        private Day02 day02;

        [TestInitialize]
        public void SetupTests()
        {
            var testInput = new[]
            {
                "forward 5","down 5","forward 8","up 3","down 8","forward 2"
            };

            day02 = new Day02(testInput);
        }

        [TestMethod]
        public void Example_Part1_ShouldReturn150()
        {
            // act
            var result = day02.SolvePart1();

            // assert
            Assert.AreEqual(150, result);
        }

        [TestMethod]
        public void Example_Part2_ShouldReturn900()
        {
            // act
            var result = day02.SolvePart2();

            // assert
            Assert.AreEqual(900, result);
        }
    }
}
