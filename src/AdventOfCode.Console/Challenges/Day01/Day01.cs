using System.ComponentModel;
using AdventOfCode.Core;

namespace AdventOfCode.Challenges;

[Description("Day 01")]
public class Day01 : Challenge<Day01>
{
    public Day01(string[] input) : base(input)
    {
    }

    public Day01() : base()
    {
    }

    public override Solution<TValueType> SolvePart1<TValueType>()
    {
        var input = _input.Select(int.Parse).ToArray();
        
        var count = 0;
        for (var i = 1; i < input.Length; i++)
        {
            if (input[i] > input[i - 1])
                count++;
        }
        return new Solution<TValueType>((TValueType)Convert.ChangeType(count, typeof(TValueType)));
    }

    public override Solution<TValueType> SolvePart2<TValueType>()
    {
        var input = _input.Select(int.Parse).ToArray();
        
        var count = 0;
        for (var i = 0; i < input.Length - 3; i++)
        {
            var nextWindow = input.Skip(i + 1).Take(3);
            if (nextWindow.Sum() > input.Skip(i).Take(3).Sum())
                count++;
        }
        return new Solution<TValueType>((TValueType)Convert.ChangeType(count, typeof(TValueType)));
    }
}
