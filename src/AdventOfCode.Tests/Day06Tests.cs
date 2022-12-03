using AdventOfCode.Challenges;

namespace AdventOfCode.Tests;

public class Day06Tests
{
    private Day06 _day06;

    [SetUp]
    public void Setup()
    {
        var testInput = new[]
        {
            "3,4,3,1,2"
        };

        _day06 = new Day06(testInput);
    }

    [Test]
    public void Example_Part1_ShouldReturn5934()
    {
        // act
        var result = _day06.SolvePart1();

        // assert
        Assert.That(result, Is.EqualTo(5934));
    }

    [Test]
    public void Example_Part2_ShouldReturn26984457539()
    {
        // act
        var result = _day06.SolvePart2();

        // assert
        Assert.That(result, Is.EqualTo(26984457539));
    }
}
