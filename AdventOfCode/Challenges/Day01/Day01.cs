namespace AdventOfCode.Challenges
{
    public class Day01
    {
        private readonly int[] input;

        public Day01() => input = File.ReadAllText("Challenges\\Day01\\Day01Input.txt").Split("\n").Select(i => int.Parse(i)).ToArray();

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

        public int SolvePart2()
        {
            var count = 0;
            var previous = input.Take(3).Sum();
            for(var i = 0; i < input.Length; i++)
            {
                var window = input.Skip(i).Take(3);
                if (window.Count() == 3)
                {
                    var current = window.Sum();
                    if (current > previous)
                    {
                        count++;
                    }
                    previous = current;
                } 
                else
                {
                    break;
                }
            }
            return count;
        }
    }
}
