using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;

namespace Benchmarks.CountPerformance;

[MemoryDiagnoser(false)]
public class ExactCountBenchmark
{
    public static IEnumerable<string> GetEnumerable(int count)
    {
        var list = new List<string>();
        for (int i = 0; i < count; i++)
        {
            list.Add(i.ToString());
        }

        return list.Distinct();
    }

    public static ICollection<string> GetList(int count)
    {
        var list = new List<string>();
        for (int i = 0; i < count; i++)
        {
            list.Add(i.ToString());
        }
        return list;
    }

    private const int CollectionSize = 100_000;
    private const int ExpectedCount100 = 100;
    private const int ExpectedCount100k = 100_000;
    
    public static IEnumerable<string> MyEnumerable = GetEnumerable(CollectionSize);
    public static ICollection<string> MyList = GetList(CollectionSize);
    public static IEnumerable<string> MyListAsEnumerable = GetList(CollectionSize);

    [Benchmark]
    public bool EnumerableHasExactCount100() => MyEnumerable.HasExactCount(ExpectedCount100);
    // [Benchmark]
    // public bool EnumerableHasExactCount1K() => MyEnumerable.HasExactCount(1000);
    // [Benchmark]
    // public bool EnumerableHasExactCount10K() => MyEnumerable.HasExactCount(10000);
    // [Benchmark]
    // public bool EnumerableHasExactCount50K() => MyEnumerable.HasExactCount(50000);
    [Benchmark]
    public bool EnumerableHasExactCount100K() => MyEnumerable.HasExactCount(ExpectedCount100k);
    [Benchmark]
    public bool EnumerableCount() => MyEnumerable.Count() == ExpectedCount100k;
    
    //
    // [Benchmark] 
    // public bool TakeCountEnumerable() => MyEnumerable.Take(ExpectedCount + 1).Count() == ExpectedCount;
    //
    // [Benchmark]
    // public bool SkipAnyEnumerable() => MyEnumerable.Skip(ExpectedCount).Any();


    // [Benchmark]
    // public bool ListHasExactCount() => MyList.HasExactCount(ExpectedCount);
    //
    // [Benchmark]
    // public bool ListCountProperty() => MyList.Count == ExpectedCount;
    //
    // [Benchmark]
    // public bool TakeCountList() => MyList.Take(ExpectedCount + 1).Count() == ExpectedCount;
    //
    // [Benchmark]
    // public bool ListDisguisedAsEnumerableCountMethod() => MyListAsEnumerable.Count() == ExpectedCount;
    //
    // [Benchmark]
    // public bool ListDisguisedAsEnumerableHasExactCount() => MyListAsEnumerable.HasExactCount(ExpectedCount);
}