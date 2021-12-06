using AdventOfCode.Challenges;

Console.WriteLine("--- Advent of Code 2021 ---\r\n");

Console.WriteLine("- Day 01 -");
Day01 day01 = new Day01(File.ReadAllLines("Challenges\\Day01\\Day01Input.txt"));
var day01Part1 = day01.SolvePart1();
Console.WriteLine($"part 1 result: {day01Part1}");
var day01Part2 = day01.SolvePart2();
Console.WriteLine($"part 2 result: {day01Part2}\r\n");

Console.WriteLine("- Day 02 -");
Day02 day02 = new Day02(File.ReadAllLines("Challenges\\Day02\\Day02Input.txt"));
var day02Part1 = day02.SolvePart1();
Console.WriteLine($"part 1 result: {day02Part1}");
var day02Part2 = day02.SolvePart2();
Console.WriteLine($"part 2 result: {day02Part2}\r\n");

Console.WriteLine("- Day 03 -");
Day03 day03 = new Day03(File.ReadAllLines("Challenges\\Day03\\Day03Input.txt"));
var day03Part1 = day03.SolvePart1();
Console.WriteLine($"part 1 result: {day03Part1}");
var day03Part2 = day03.SolvePart2();
Console.WriteLine($"part 2 result: {day03Part2}\r\n");

Console.WriteLine("- Day 04 -");
Day04 day04 = new Day04(File.ReadAllLines("Challenges\\Day04\\Day04Input.txt"));
var day04Part1 = day04.SolvePart1();
Console.WriteLine($"part 1 result: {day04Part1}");
var day04Part2 = day04.SolvePart2();
Console.WriteLine($"part 2 result: {day04Part2}\r\n");

Console.WriteLine("- Day 05 -");
Day05 day05 = new Day05(File.ReadAllLines("Challenges\\Day05\\Day05Input.txt"));
var day05Part1 = day05.SolvePart1();
Console.WriteLine($"part 1 result: {day05Part1}");
var day05Part2 = day05.SolvePart2();
Console.WriteLine($"part 2 result: {day05Part2}\r\n");

Console.WriteLine("- Day 06 -");
Day06 day06 = new Day06(File.ReadAllText("Challenges\\Day06\\Day06Input.txt"));
var day06Part1 = day06.SolvePart1();
Console.WriteLine($"part 1 result: {day06Part1}");
var day06Part2 = day06.SolvePart2();
Console.WriteLine($"part 2 result: {day06Part2}\r\n");

Console.WriteLine("- Day 07 -");
Day07 day07 = new Day07(File.ReadAllLines("Challenges\\Day07\\Day07Input.txt"));
var day07Part1 = day07.SolvePart1();
Console.WriteLine($"part 1 result: {day07Part1}");
var day07Part2 = day07.SolvePart2();
Console.WriteLine($"part 2 result: {day07Part2}\r\n");