namespace AdventOfCode.Challenges
{
    public class Day05
    {
        private readonly string[] input;

        public Day05(string[] Input) => input = Input;

        public int SolvePart1()
        {
            Dictionary<(int, int), int> positions = new Dictionary<(int, int), int>();
            foreach (var range in input)
            {
                var startAndEnd = range.Split(" -> ");

                var start = startAndEnd[0].Split(',').Select(int.Parse).ToArray();
                var end = startAndEnd[1].Split(',').Select(int.Parse).ToArray();

                var startX = start[0];
                var startY = start[1];
                var endX = end[0];
                var endY = end[1];

                if (startX != endX && startY != endY)
                {
                    continue;
                }

                if (start[0] > end[0] || start[1] > end[1])
                {
                    startX = end[0];
                    startY = end[1];
                    endX = start[0];
                    endY = start[1];
                }

                for (var x = startX; x <= endX; x++)
                {
                    for (var y = startY; y <= endY; y++)
                    {
                        if (positions.ContainsKey((x, y)))
                        {
                            positions[(x, y)] += 1;
                        } 
                        else
                        {
                            positions.Add((x, y), 1);
                        }
                    }
                }
            }

            return positions.Count(x => x.Value > 1);
        }

        public int SolvePart2()
        {
            return 0;
        }
    }
}
