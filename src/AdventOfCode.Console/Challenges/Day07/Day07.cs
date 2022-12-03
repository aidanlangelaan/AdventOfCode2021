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

    public override Solution<TValueType> SolvePart1<TValueType>()
    {
        // var crabbies = _input;
        //
        // // get median
        // crabbies.Sort();
        // var median = crabbies[crabbies.Count / 2];
        //
        // // get fuel to median
        // var fuelUsage = crabbies.GroupBy(x => x)
        //     .Select(x => x.Count() * Math.Abs(x.Key - median));
        //
        // return fuelUsage.Sum();

        return new Solution<TValueType>((TValueType)Convert.ChangeType(0, typeof(TValueType)));
    }

    public override Solution<TValueType> SolvePart2<TValueType>()
    {
        // var count = test();
        // //var crabbies = input;
        //
        // //// get average
        // //var highAverage = Math.Ceiling(crabbies.Average());
        // //var minAverage = highAverage - 1;
        //
        // //// get fuel to average
        // //var fuelUsageHighAverage = crabbies.GroupBy(x => x)
        // //    .Select(x => x.Count() * CalculateFuelUsageToMean(Math.Abs(x.Key - highAverage))).Sum();
        // //var fuelUsageLowAverage = crabbies.GroupBy(x => x)
        // //    .Select(x => x.Count() * CalculateFuelUsageToMean(Math.Abs(x.Key - highAverage))).Sum();
        //
        // //return Math.Min((int)fuelUsageLowAverage, (int)fuelUsageHighAverage);
        //
        // return count;
        
        return new Solution<TValueType>((TValueType)Convert.ChangeType(0, typeof(TValueType)));
    }

    // private double CalculateFuelUsageToMean(double steps) => (Math.Pow(steps, 2) + steps) / 2;
    //
    // private int test()
    // {
    //     int min = _input.Min();
    //     int max = _input.Max();
    //
    //     int lowest = int.MaxValue;
    //     for (int pos = min; pos < max; pos++)
    //     {
    //         int test = (int)_input.Select(x => CalculateFuelUsageToMean(Math.Abs(x - pos))).Sum();
    //         if (test < lowest)
    //             lowest = test;
    //     }
    //
    //     return lowest;
    // }
}
