using AdventOfCode.Challenges;

namespace AdventOfCode.Tests;

public class Day02Tests
{
    private Day02 _day02;

    [SetUp]
    public void Setup()
    {
        var testInput = new[]
        {
            "forward 5","down 5","forward 8","up 3","down 8","forward 2"
        };

        _day02 = new Day02(testInput);
    }

    [Test]
    public void Example_Part1_ShouldReturn150()
    {
        // act
        var result = _day02.SolvePart1<int>();

        // assert
        Assert.That(result.Value, Is.EqualTo(150));
    }

    [Test]
    public void Example_Part2_ShouldReturn900()
    {
        // act
        var result = _day02.SolvePart2<int>();

        // assert
        Assert.That(result.Value, Is.EqualTo(900));
    }
}
