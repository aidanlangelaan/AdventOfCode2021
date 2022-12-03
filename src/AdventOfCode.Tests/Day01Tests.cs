using AdventOfCode.Challenges;

namespace AdventOfCode.Tests;

public class Day01Tests
{
    private Day01 _day01;

    [SetUp]
    public void Setup()
    {
        var testInput = new[]
        {
            "199","200","208","210","200","207","240","269","260","263"
        };

        _day01 = new Day01(testInput);
    }

    [Test]
    public void Example_Part1_ShouldReturn7()
    {
        // act
        var result = _day01.SolvePart1<int>();

        // assert
        Assert.That(result.Value, Is.EqualTo(7));
    }

    [Test]
    public void Example_Part2_ShouldReturn5()
    {
        // act
        var result = _day01.SolvePart2<int>();

        // assert
        Assert.That(result.Value, Is.EqualTo(5));
    }
}
