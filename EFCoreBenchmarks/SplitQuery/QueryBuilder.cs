using System;
using System.Linq;
using EFCoreBenchmarks.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreBenchmarks.SplitQuery;

public static class QueryBuilder
{
    public static IQueryable<Aggregate> GetQueryWithMultipleIncludes(this DbSet<Aggregate> dbSet, int joinsCount)
    {
        return joinsCount switch
        {
            0 => dbSet,
            1 => dbSet.Include(x => x.Entities1),
            2 => dbSet.Include(x => x.Entities1).Include(x => x.Entities2),
            3 => dbSet.Include(x => x.Entities1).Include(x => x.Entities2).Include(x => x.Entities3),
            4 => dbSet.Include(x => x.Entities1).Include(x => x.Entities2).Include(x => x.Entities3).Include(x => x.Entities4),
            5 => dbSet.Include(x => x.Entities1).Include(x => x.Entities2).Include(x => x.Entities3).Include(x => x.Entities4).Include(x => x.Entities5),
            _ => throw new ArgumentOutOfRangeException()
        };
    }
}