using System.ComponentModel;
using AdventOfCode.Core;

namespace AdventOfCode.Challenges;

[Description("Day 06")]
public class Day06 : Challenge<Day06>
{
    public Day06(string[] Input) : base(Input)
    {
    }

    public Day06() : base()
    {
    }

    public override int SolvePart1()
    {
        var fishies = BreedFishForDays(80);
        return fishies.Sum(f => f.Count);
    }

    public override int SolvePart2()
    {
        var fishies = BreedFishForDays(256);
        return fishies.Sum(f => f.Count);
    }

    private List<FishGroup> BreedFishForDays(int days)
    {
        var day = 0;
        var fishyGroups = input.GroupBy(i => i)
            .Select(f => new FishGroup { Age = f.Key, Count = f.Count() })
            .ToList();

        while (day < days)
        {
            List<FishGroup> updatedFish = new List<FishGroup>();
            for (var i = 0; i < fishyGroups.Count(); i++)
            {
                var fishGroup = fishyGroups[i];
                if (fishGroup.Age == 0)
                {
                    updatedFish.Add(new FishGroup { Age = 8, Count = fishGroup.Count });
                    updatedFish.Add(new FishGroup { Age = 6, Count = fishGroup.Count });

                    continue;
                }
                else if (fishGroup.Age - 1 > 5)
                {
                    var existingGroup = updatedFish.Where(x => x.Age == fishGroup.Age - 1).FirstOrDefault();
                    if (existingGroup != null)
                    {
                        existingGroup.Count += fishGroup.Count;
                        var groupIndex = updatedFish.FindIndex(x => x.Age == fishGroup.Age - 1);
                        updatedFish[groupIndex] = existingGroup;
                        continue;
                    }
                }

                updatedFish.Add(new FishGroup { Age = fishGroup.Age - 1, Count = fishGroup.Count });
            }
            fishyGroups = updatedFish;
            day++;
        }
        return fishyGroups;
    }

    internal class FishGroup
    {
        public int Age { get; set; }
        public long Count { get; set; }
    }
}
