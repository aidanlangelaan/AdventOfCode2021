using System.ComponentModel;
using AdventOfCode.Core;

namespace AdventOfCode.Challenges;

[Description("Day 02")]
public class Day02 : Challenge<Day02>
{
    public Day02(string[] input) : base(input)
    {
    }

    public Day02() : base()
    {
    }

    public override Solution<TValueType> SolvePart1<TValueType>()
    {
        var horizontal = 0;
        var depth = 0;
        foreach (var i in _input)
        {
            var direction = i.Split(' ')[0];
            var amount = int.Parse(i.Split(' ')[1]);
            switch (direction)
            {
                case "up":
                    depth -= amount;
                    break;
                case "down":
                    depth += amount;
                    break;
                case "forward":
                    horizontal += amount;
                    break;
            }
        }
        return new Solution<TValueType>((TValueType)Convert.ChangeType(horizontal * depth, typeof(TValueType)));
    }

    public override Solution<TValueType> SolvePart2<TValueType>()
    {
        var horizontal = 0;
        var depth = 0;
        var aim = 0;
        foreach (var i in _input)
        {
            var direction = i.Split(' ')[0];
            var amount = int.Parse(i.Split(' ')[1]);
            switch (direction)
            {
                case "up":
                    aim -= amount;
                    break;
                case "down":
                    aim += amount;
                    break;
                case "forward":
                    horizontal += amount;
                    depth += aim * amount;
                    break;
            }
        }
        return new Solution<TValueType>((TValueType)Convert.ChangeType(horizontal * depth, typeof(TValueType)));
    }
}
