using System.ComponentModel;
using AdventOfCode.Core;

namespace AdventOfCode.Challenges;

[Description("Day 06")]
public class Day06 : Challenge<Day06>
{
    public Day06(string[] input) : base(input)
    {
    }

    public Day06() : base()
    {
    }

    public override Solution<TValueType> SolvePart1<TValueType>()
    {
        var fish = BreedFishForDays(80);
        return new Solution<TValueType>((TValueType)Convert.ChangeType(fish.Sum(f => f.Count), typeof(TValueType)));
    }

    public override Solution<TValueType> SolvePart2<TValueType>()
    {
        var fish = BreedFishForDays(256);
        long result = fish.Sum(f => (long)f.Count);
        
        return new Solution<TValueType>((TValueType)Convert.ChangeType(result, typeof(TValueType)));
    }

    private List<FishGroup> BreedFishForDays(int days)
    {
        var input = _input.First().Split(',').Select(int.Parse).ToList();

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
                    var existingGroup = updatedFish.FirstOrDefault(x => x.Age == fishGroup.Age - 1);
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

    private class FishGroup
    {
        public int Age { get; init; }
        public int Count { get; set; }
    }
}
