using AdventOfCode.Challenges;

namespace AdventOfCode.Tests;

public class Day05Tests
{
    private Day05 _day05;

    [SetUp]
    public void Setup()
    {
        var testInput = new[]
        {
            "0,9 -> 5,9","8,0 -> 0,8","9,4 -> 3,4","2,2 -> 2,1","7,0 -> 7,4","6,4 -> 2,0","0,9 -> 2,9","3,4 -> 1,4","0,0 -> 8,8","5,5 -> 8,2"
        };

        _day05 = new Day05(testInput);
    }

    [Test]
    public void Example_Part1_ShouldReturn5()
    {
        // act
        var result = _day05.SolvePart1<int>();

        // assert
        Assert.That(result.Value, Is.EqualTo(5));
    }

    [Test]
    public void Example_Part2_ShouldReturn12()
    {
        // act
        var result = _day05.SolvePart2<int>();

        // assert
        Assert.That(result.Value, Is.EqualTo(12));
    }
}
