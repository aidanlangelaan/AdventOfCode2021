namespace AdventOfCode.Challenges
{
    public class Day01
    {
        private readonly int[] input;

        public Day01() => input = File.ReadAllText("Challenges\\Day01\\Day1Input.txt").Split("\n").Select(i => int.Parse(i)).ToArray();

        public int SolvePart1()
        {
            var count = 0;
            var previous = input[0];
            foreach (var i in input)
            {
                if (i > previous)
                {
                    count++;
                }
                previous = i;
            }
            return count;
        }
    }
}
