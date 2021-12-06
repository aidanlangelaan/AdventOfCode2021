namespace AdventOfCode.Challenges
{
    public class Day06
    {
        private readonly List<int> input;

        public Day06(string Input) => input = Input.Split(',').Select(int.Parse).ToList();

        public int SolvePart1()
        {
            var fishies = input;
            var maxDays = 80;
            var day = 0;
            while (day < maxDays)
            {
                var babyFish = new List<int>();
                fishies = fishies.Select(x =>
                {
                    if (x == 0)
                    {
                        babyFish.Add(8);
                        x = 6;
                    } else
                    {
                        x--;
                    }

                    return x;
                }).ToList();

                fishies.AddRange(babyFish);

                day++;
            }
            return fishies.Count;
        }

        public int SolvePart2()
        {
            return 0;
        }
    }
}
