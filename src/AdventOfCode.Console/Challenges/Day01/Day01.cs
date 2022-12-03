using System.ComponentModel;
using AdventOfCode.Core;

namespace AdventOfCode.Challenges;

[Description("Day 01")]
public class Day01 : Challenge<Day01>
{
    public Day01(string[] Input) : base(Input)
    {
    }

    public Day01() : base()
    {
    }

    public override int SolvePart1()
    {
        var count = 0;
        for (var i = 1; i < input.Length; i++)
        {
            if (input[i] > input[i - 1])
                count++;
        }
        return count;
    }

    public override int SolvePart2()
    {
        var count = 0;
        for (var i = 0; i < input.Length - 3; i++)
        {
            var nextWindow = input.Skip(i + 1).Take(3);
            if (nextWindow.Sum() > input.Skip(i).Take(3).Sum())
                count++;
        }
        return count;
    }
}
