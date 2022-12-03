namespace AdventOfCode.Core;

public class Solution<TValueType>
{
    public Solution(TValueType value)
    {
        Value = value;
    }

    public TValueType Value { get; }
}