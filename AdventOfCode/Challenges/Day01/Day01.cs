namespace AdventOfCode.Challenges
{
    public class Day01
    {
        private readonly int[] input;

        public Day01(string[] Input) => input = Input.Select(i => int.Parse(i)).ToArray();

        public int SolvePart1()
        {
            var count = 0;
            for (var i = 1; i < input.Length; i++)
            {
                if (input[i] > input[i-1])
                    count++;
            }
            return count;
        }

        public int SolvePart2()
        {
            var count = 0;
            for (var i = 0; i < input.Length-3; i++)
            {
                var nextWindow = input.Skip(i+1).Take(3);
                if (nextWindow.Sum() > input.Skip(i).Take(3).Sum())
                    count++;
            }
            return count;
        }
    }
}
