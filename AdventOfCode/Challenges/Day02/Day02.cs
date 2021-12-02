namespace AdventOfCode.Challenges
{
    public class Day02
    {
        private readonly string[] input;

        public Day02() => input = File.ReadAllLines("Challenges\\Day02\\Day02Input.txt").ToArray();

        public int SolvePart1()
        {
            var horizontal = 0;
            var depth = 0;
            foreach(var i in input)
            {
                var direction = i.Split(' ')[0];
                var amount = int.Parse(i.Split(' ')[1]);
                switch (direction)
                {
                    case "up":
                        depth -= amount;
                        break;
                    case "down":
                        depth += amount;
                        break;
                    case "forward":
                        horizontal += amount;
                        break;
                }
            }
            return horizontal * depth;
        }

        public int SolvePart2()
        {
            var horizontal = 0;
            var depth = 0;
            var aim = 0;
            foreach (var i in input)
            {
                var direction = i.Split(' ')[0];
                var amount = int.Parse(i.Split(' ')[1]);
                switch (direction)
                {
                    case "up":
                        aim -= amount;
                        break;
                    case "down":
                        aim += amount;
                        break;
                    case "forward":
                        horizontal += amount;
                        depth += aim * amount;
                        break;
                }
            }
            return horizontal * depth;
        }
    }
}
