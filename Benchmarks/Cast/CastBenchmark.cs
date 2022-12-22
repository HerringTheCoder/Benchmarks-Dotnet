using System;
using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;

namespace Benchmarks.Cast;

[MemoryDiagnoser(false)]
public class CastBenchmark
{
    public static ICollection<AggregateCreatedDomainEvent> GetList(int count)
    {
        var list = new List<AggregateCreatedDomainEvent>();
        for (int i = 0; i < count; i++)
        {
            list.Add(new AggregateCreatedDomainEvent(Guid.NewGuid(), 
                new Dictionary<Guid, List<string>>
                {
                    {Guid.NewGuid(), new List<string> {"A1, B2, C3"}},
                    {Guid.NewGuid(), new List<string> {"A1, B2, C3"}},
                    {Guid.NewGuid(), new List<string> {"A1, B2, C3"}},
                },
                DateTimeOffset.Now));
        }
        return list;
    }

    private const int CollectionSize = 100_000;

    public static readonly ICollection<AggregateCreatedDomainEvent> MyList = GetList(CollectionSize);
    public static readonly ICollection<KeyValuePair<Guid, List<string>>> Entries = MyList.SelectMany(x => x.Entries).ToList();
    
    public static Guid StaticGuid = Guid.NewGuid();
    public static DateTimeOffset? StaticDateTime = DateTimeOffset.UtcNow;

    [Benchmark]
    public List<IIntegrationEvent> LinqEnumerableCast() => Entries
        .Select(x =>
        new EntriesModifiedIntegrationEvent(
            x.Key,
            x.Value,
            StaticDateTime,
            StaticGuid
        )).Cast<IIntegrationEvent>().ToList();
    
    [Benchmark]
    public List<IIntegrationEvent> SelectCast() => Entries.Select(
        x =>
        new EntriesModifiedIntegrationEvent(
            x.Key,
            x.Value,
            StaticDateTime,
            StaticGuid
        ) as IIntegrationEvent).ToList();
}