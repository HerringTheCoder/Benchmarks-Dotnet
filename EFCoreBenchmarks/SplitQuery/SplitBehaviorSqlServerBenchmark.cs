using System.Collections.Generic;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using EFCoreBenchmarks.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreBenchmarks.SplitQuery;

[MemoryDiagnoser(false)]
public class SplitBehaviorSqlServerBenchmark
{
    private MyContext _context = null!;

    public IEnumerable<int> JoinsCounts => new[] { 0, 1, 2, 3, 4, 5 };
    
    [ParamsSource(nameof(JoinsCounts))]
    public int IncludesCount;

    [GlobalSetup]
    public void Setup()
    {
        var context = new MyContext();
        context.Database.EnsureCreated();
        context.Set<Aggregate>().ExecuteDelete();

        for (int i = 0; i < 10; i++)
        {
            var aggregate = new Aggregate
            {
                Name = $"Name-{i}",
                Description = $"Description-{i}"
            };
            
            for (int j = 0; j < 10; j++)
            {
                aggregate.Entities1.Add(new Entity1{Name = $"Name-{i}", Description = $"Description-{i}"});
                aggregate.Entities2.Add(new Entity2{Name = $"Name-{i}", Description = $"Description-{i}"});
                aggregate.Entities3.Add(new Entity3{Name = $"Name-{i}", Description = $"Description-{i}"});
                aggregate.Entities4.Add(new Entity4{Name = $"Name-{i}", Description = $"Description-{i}"});
                aggregate.Entities5.Add(new Entity5{Name = $"Name-{i}", Description = $"Description-{i}"});
            }

            context.Add(aggregate);
        }

        context.SaveChanges();
    }

    [IterationSetup]
    public void CreateContext()
    {
        _context = new MyContext();
    }

    [Benchmark]
    public async Task<List<Aggregate>> JoinQuery()
    {
        var result = await _context.Set<Aggregate>()
            .GetQueryWithMultipleIncludes(IncludesCount)
            .AsSingleQuery()
            .ToListAsync();

        return await Task.FromResult(result);
    }

    [Benchmark]
    public async Task<List<Aggregate>> SplitQuery()
    {
        var result = await _context.Set<Aggregate>()
            .GetQueryWithMultipleIncludes(IncludesCount)
            .AsSplitQuery()
            .ToListAsync();

        return await Task.FromResult(result);
    }
}