using System.ComponentModel;
using AdventOfCode.Core;

namespace AdventOfCode.Challenges;

[Description("Day 03")]
public class Day03 : Challenge<Day03>
{
    public Day03(string[] input) : base(input)
    {
    }

    public Day03() : base()
    {
    }

    public override Solution<TValueType> SolvePart1<TValueType>()
    {
        var mostCommonNumberStr = string.Empty;
        for (var i = 0; i < _input[0].Length; i++)
        {
            var mostCommonNumber = GetCommonNumber(i, _input, true);
            mostCommonNumberStr = $"{mostCommonNumberStr}{mostCommonNumber}";
        }

        var leastCommonNumberStr = string.Empty;
        for (var i = 0; i < _input[0].Length; i++)
        {
            var leastCommonNumber = GetCommonNumber(i, _input, false);
            leastCommonNumberStr = $"{leastCommonNumberStr}{leastCommonNumber}";
        }

        return new Solution<TValueType>((TValueType)Convert.ChangeType(Convert.ToInt32(mostCommonNumberStr, 2) * Convert.ToInt32(leastCommonNumberStr, 2), typeof(TValueType)));
    }

    public override Solution<TValueType> SolvePart2<TValueType>()
    {
        var oxygen = GetRating(true);
        var co2 = GetRating(false);

        return new Solution<TValueType>((TValueType)Convert.ChangeType(Convert.ToInt32(oxygen, 2) * Convert.ToInt32(co2, 2), typeof(TValueType)));
    }

    private string GetRating(bool mostCommon)
    {
        var col = 0;
        var numbersInput = _input;
        while (numbersInput.Length > 1)
        {
            var commonNumber = GetCommonNumber(col, numbersInput, mostCommon);
            numbersInput = numbersInput.Where(x => x[col].ToString() == commonNumber).ToArray();
            col++;
        }
        return numbersInput[0];
    }

    private string GetCommonNumber(int column, string[] numbersInput, bool mostCommon)
    {
        var zeroCount = numbersInput.Count(x => x[column] == '0');
        var oneCount = numbersInput.Count(x => x[column] == '1');
        if (mostCommon)
        {
            return oneCount >= zeroCount ? "1" : "0";
        }
        else
        {
            return oneCount >= zeroCount ? "0" : "1";
        }
    }
}
