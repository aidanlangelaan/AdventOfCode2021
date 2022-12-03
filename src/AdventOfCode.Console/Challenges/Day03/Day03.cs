using System.ComponentModel;
using AdventOfCode.Core;

namespace AdventOfCode.Challenges;

[Description("Day 03")]
public class Day03 : Challenge<Day03>
{
    public Day03(string[] Input) : base(Input)
    {
    }

    public Day03() : base()
    {
    }

    public override int SolvePart1()
    {
        var mostCommonNumberStr = string.Empty;
        for (var i = 0; i < input[0].Length; i++)
        {
            var mostCommonNumber = GetCommonNumber(i, input, true);
            mostCommonNumberStr = $"{mostCommonNumberStr}{mostCommonNumber}";
        }

        var leastCommonNumberStr = string.Empty;
        for (var i = 0; i < input[0].Length; i++)
        {
            var leastCommonNumber = GetCommonNumber(i, input, false);
            leastCommonNumberStr = $"{leastCommonNumberStr}{leastCommonNumber}";
        }

        return Convert.ToInt32(mostCommonNumberStr, 2) * Convert.ToInt32(leastCommonNumberStr, 2);
    }

    public override int SolvePart2()
    {
        var oxygen = GetRating(true);
        var co2 = GetRating(false);

        return Convert.ToInt32(oxygen, 2) * Convert.ToInt32(co2, 2);
    }

    private string GetRating(bool mostCommon)
    {
        var col = 0;
        var numbersInput = input;
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
