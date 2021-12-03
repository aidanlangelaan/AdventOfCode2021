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