namespace AdventOfCode.Challenges
{
    public class Day04
    {
        private readonly string[] input;

        public Day04(string[] Input) => input = Input.Where(x => !string.IsNullOrEmpty(x)).ToArray();

        public int SolvePart1()
        {
            var draws = input[0].Split(',').Select(int.Parse);
            var bingo = input[1..input.Length];
            var boards = SetupBoards(bingo);

            KeyValuePair<int, Dictionary<(int, int), (int, bool)>>? winningBoard = null;
            var winningDraw = 0;

            foreach (var draw in draws)
            {
                boards = UpdateBoard(boards, draw);
                var result = ValidateBoards(boards);
                if (result.HasValue)
                {
                    winningBoard = result.Value;
                    winningDraw = draw;
                    break;
                }
            }

            var unmarked = winningBoard.Value.Value.Where(x => !x.Value.Item2).Sum(x => x.Value.Item1);
            return unmarked * winningDraw;
        }
        public int SolvePart2()
        {
            return 0;
        }

        private static KeyValuePair<int, Dictionary<(int, int), (int, bool)>>? ValidateBoards(Dictionary<int, Dictionary<(int, int), (int, bool)>> boards)
        {
            KeyValuePair<int, Dictionary<(int, int), (int, bool)>>? winningBoard = null;
            var completeCheck = false;
            while (!winningBoard.HasValue && !completeCheck)
            {
                foreach (var board in boards)
                {
                    for (var row = 0; row < 5; row++)
                    {
                        var allTrue = board.Value.Where(x => x.Key.Item1 == row && x.Value.Item2 == true).ToArray();
                        if (allTrue.Any() && allTrue.Length == 5)
                        {
                            winningBoard = board;
                            completeCheck = true;
                            break;
                        }
                    }

                    for (var column = 0; column < 5; column++)
                    {
                        var allTrue = board.Value.Where(x => x.Key.Item1 == column && x.Value.Item2 == true).ToArray();
                        if (allTrue.Any() && allTrue.Length == 5)
                        {
                            winningBoard = board;
                            completeCheck = true;
                            break;
                        }
                    }
                }
                completeCheck = true;
            }
            return winningBoard;
        }

        private static Dictionary<int, Dictionary<(int, int), (int, bool)>> UpdateBoard(Dictionary<int, Dictionary<(int, int), (int, bool)>> boards, int draw)
        {
            foreach (var board in boards)
            {
                for (var row = 0; row < 5; row++)
                {
                    for (var column = 0; column < 5; column++)
                    {
                        var item = board.Value[(row, column)];
                        if (item.Item1 == draw)
                        {
                            board.Value[(row, column)] = (draw, true);
                        }
                    }
                }
            }

            return boards;
        }

        private static Dictionary<int, Dictionary<(int, int), (int, bool)>> SetupBoards(string[] input)
        {
            var numberOfBoards = input.Length / 5;
            Dictionary<int, Dictionary<(int, int), (int, bool)>> boards = new Dictionary<int, Dictionary<(int, int), (int, bool)>>();
            for (var boardCount = 0; boardCount < numberOfBoards; boardCount++)
            {
                Dictionary<(int, int), (int, bool)> board = new Dictionary<(int, int), (int, bool)>();
                var rows = input.Skip(boards.Count * 5).Take(5).ToArray();
                for (int i = 0; i < rows.Count(); i++)
                {
                    var columns = rows[i].Split(' ')
                        .Where(d => d != string.Empty)
                        .Select(d => Convert.ToInt32(d))
                        .ToArray();

                    for (var j = 0; j < 5; j++)
                    {
                        board.Add((i, j), (columns[j], false));
                    }
                }
                boards.Add(boardCount, board);
            }
            return boards;
        }

    }
}
