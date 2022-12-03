using AdventOfCode.Challenges;

namespace AdventOfCode.Tests;

public class Day07Tests
{
    private Day07 _day07;

    [SetUp]
    public void Setup()
    {
        var testInput = new[]
        {
            "16,1,2,0,4,2,7,1,2,14"
        };

        _day07 = new Day07(testInput);
    }

    [Test]
    public void Example_Part1_ShouldReturn37()
    {
        // act
        var result = _day07.SolvePart1();

        // assert
        Assert.That(result, Is.EqualTo(37));
    }

    [Test]
    public void Example_Part2_ShouldReturn168()
    {
        // act
        var result = _day07.SolvePart2();

        // assert
        Assert.That(result, Is.EqualTo(168));
    }
}
