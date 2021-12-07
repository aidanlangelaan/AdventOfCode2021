namespace AdventOfCode.Challenges
{
    public class Day07
    {
        private readonly List<int> input;

        public Day07(string Input) => input = Input.Split(',').Select(int.Parse).ToList();

        public int SolvePart1()
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

        public int SolvePart2()
        {
            return 0;
        }
    }
}
