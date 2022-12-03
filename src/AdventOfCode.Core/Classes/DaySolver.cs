using System.Diagnostics;

namespace AdventOfCode.Core;

public class DaySolver<TDay> where TDay : Challenge<TDay>
{
    private readonly bool _displayPerformance;
    private readonly TDay _day;
    private readonly Stopwatch _timer;

    public DaySolver(bool displayPerformance = false)
    {
        _displayPerformance = displayPerformance;
        
        _day = Activator.CreateInstance<TDay>();
        if (_day == null)
        {
            throw new Exception("Instance not found");
        }

        _timer = new Stopwatch();
    }

    public void SolvePart1<TValueType>()
    {
        _timer.Reset();
        _timer.Start();
        
        var result = _day.SolvePart1<TValueType>();
        
        _timer.Stop();

        OutputResult(result.Value.ToString(), 1);
    }

    public void SolvePart2<TValueType>()
    {
        _timer.Reset();
        _timer.Start();
        
        var result = _day.SolvePart2<TValueType>();
        
        _timer.Stop();

        OutputResult(result.Value.ToString(), 2);
    }
    
    
    private void OutputResult(string result, int part)
    {
        var consoleOutput = $"part {part} result: {result}";
        if (_displayPerformance)
        {
            consoleOutput += $" ({_timer.ElapsedMilliseconds}ms)";
        }

        Console.WriteLine(consoleOutput);
    }
}