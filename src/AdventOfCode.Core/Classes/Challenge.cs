using System.ComponentModel;

namespace AdventOfCode.Core;

public abstract class Challenge<TDay>
{
    protected string[] _input;

    protected Challenge(string[] input)
    {
        PrintDescription();
        _input = input;
    }

    protected Challenge()
    {
        PrintDescription();
        _input = File.ReadAllLines($"Challenges\\{typeof(TDay).Name}\\Input.txt");
    }

    public abstract Solution<TValueType> SolvePart1<TValueType>();
    
    public abstract Solution<TValueType> SolvePart2<TValueType>();
    
    private static void PrintDescription()
    {
        var descriptions = (DescriptionAttribute[])typeof(TDay).GetCustomAttributes(typeof(DescriptionAttribute), false);
        if (descriptions.Length != 0)
        {
            Console.WriteLine($"\r\n- {descriptions.First().Description} -");
        }
    }
}