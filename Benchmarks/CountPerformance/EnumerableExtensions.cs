using System.Collections.Generic;
using System.Linq;

namespace Benchmarks.CountPerformance;

public static class EnumerableExtensions
{
    public static bool HasExactCount<T>(this IEnumerable<T> sequence, int expectedCount)
    {
        //Use Count property if it's already calculated.
        if (sequence.TryGetNonEnumeratedCount(out int actualCount))
        {
            return actualCount == expectedCount;
        }

        if (sequence.Skip(expectedCount).FirstOrDefault() == null)
        {
            return true;
        };

        return false;
    }
}