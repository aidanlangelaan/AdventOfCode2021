using AdventOfCode.Challenges;

namespace AdventOfCode.Tests;

public class Day03Tests
{
    private Day03 _day03;

    [SetUp]
    public void Setup()
    {
        var testInput = new[]
        {
            "00100","11110","10110","10111","10101","01111","00111","11100","10000","11001","00010","01010"
        };

        _day03 = new Day03(testInput);
    }

    [Test]
    public void Example_Part1_ShouldReturn198()
    {
        // act
        var result = _day03.SolvePart1<int>();

        // assert
        Assert.That(result.Value, Is.EqualTo(198));
    }

    [Test]
    public void Example_Part2_ShouldReturn230()
    {
        // act
        var result = _day03.SolvePart2<int>();

        // assert
        Assert.That(result.Value, Is.EqualTo(230));
    }
}
