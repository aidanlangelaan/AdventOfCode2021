using System.ComponentModel;
using AdventOfCode.Core;

namespace AdventOfCode.Challenges;

[Description("Day 07")]
public class Day07 : Challenge<Day07>
{
    public Day07(string[] Input) : base(Input)
    {
    }

    public Day07() : base()
    {
    }

    public override int SolvePart1()
    {
        var crabbies = input;

        // get median
        crabbies.Sort();
        var median = crabbies[crabbies.Count / 2];

        // get fuel to median
        var fuelUsage = crabbies.GroupBy(x => x)
            .Select(x => x.Count() * Math.Abs(x.Key - median));

        return fuelUsage.Sum();
    }

    public override int SolvePart2()
    {
        var count = test();
        //var crabbies = input;

        //// get average
        //var highAverage = Math.Ceiling(crabbies.Average());
        //var minAverage = highAverage - 1;

        //// get fuel to average
        //var fuelUsageHighAverage = crabbies.GroupBy(x => x)
        //    .Select(x => x.Count() * CalculateFuelUsageToMean(Math.Abs(x.Key - highAverage))).Sum();
        //var fuelUsageLowAverage = crabbies.GroupBy(x => x)
        //    .Select(x => x.Count() * CalculateFuelUsageToMean(Math.Abs(x.Key - highAverage))).Sum();

        //return Math.Min((int)fuelUsageLowAverage, (int)fuelUsageHighAverage);

        return count;
    }

    private double CalculateFuelUsageToMean(double steps) => (Math.Pow(steps, 2) + steps) / 2;

    private int test()
    {
        int min = input.Min();
        int max = input.Max();

        int lowest = int.MaxValue;
        for (int pos = min; pos < max; pos++)
        {
            int test = (int)input.Select(x => CalculateFuelUsageToMean(Math.Abs(x - pos))).Sum();
            if (test < lowest)
                lowest = test;
        }

        return lowest;
    }
}
