namespace AdventOfCode.Challenges
{
    public class Day03
    {
        private readonly string[] input;

        public Day03() => input = File.ReadAllLines("Challenges\\Day03\\Day03Input.txt").ToArray();

        public int SolvePart1()
        {
            var mostCommonNumberStr = string.Empty;
            for(var i = 1; i < input[0].Length; i++)
            {
                var mostCommonNumber = GetCommonNumber(i - 1);
                mostCommonNumberStr = $"{mostCommonNumberStr}{mostCommonNumber}";
            }

            var leastCommonNumberStr = string.Empty;
            foreach (var number in mostCommonNumberStr)
            {
                var convert = number == '0' ? '1' : '0';
                leastCommonNumberStr = $"{leastCommonNumberStr}{convert}";
            }

            return (Convert.ToInt32(mostCommonNumberStr, 2) * 2) * (Convert.ToInt32(leastCommonNumberStr, 2) * 2);
        }

        public int SolvePart2()
        {
            return 0;
        }

        public int GetCommonNumber(int column)
        {
            var countZero = 0;
            var countOne = 0;
            for (var i = 0; i < input.Length; i++)
            {
                var value = input[i].Substring(column, 1);
                if (value == "0") countZero++;
                if (value == "1") countOne++;
            }
            return countOne > countZero ? 1 : 0;
        }
    }
}
