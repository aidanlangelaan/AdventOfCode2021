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
        var result = _day06.SolvePart1<int>();

        // assert
        Assert.That(result.Value, Is.EqualTo(5934));
    }

    [Test]
    public void Example_Part2_ShouldReturn26984457539()
    {
        // act
        var result = _day06.SolvePart2<long>();

        // assert
        Assert.That(result.Value, Is.EqualTo(26984457539));
    }
}
