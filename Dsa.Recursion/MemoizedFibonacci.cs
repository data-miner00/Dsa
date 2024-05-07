namespace Dsa.Recursion;

using System.Collections.Generic;

public sealed class MemoizedFibonacci
{
    private readonly Dictionary<int, int> memoizer = new();
    private readonly List<int> sequence = new();

    public int CacheHits { get; private set; } = 0;

    public int Get(int position)
    {
        var key = position;

        if (this.memoizer.TryGetValue(key, out var value))
        {
            this.CacheHits++;
            return value;
        }

        if (key == 0)
        {
            return 0;
        }
        else if (key == 1)
        {
            return 1;
        }

        var result = this.Get(key - 1) + this.Get(key - 2);

        this.memoizer.Add(key, result);

        return result;
    }

    public List<int> GenerateSequence(int length = 3)
    {
        for (var i = 0; i < length; i++)
        {
            this.sequence.Add(this.Get(i));
        }

        return this.sequence;
    }
}
