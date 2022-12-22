using EFCoreBenchmarks.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreBenchmarks;

public class MyContext : DbContext
{
    private static readonly string DefaultConnectionString = "Server=localhost;Database=benchmark-db;User ID=sa;Password=Passw0rd123;Trusted_Connection=False;Encrypt=False;";
    
    public DbSet<Aggregate> Aggregates => Set<Aggregate>();
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(DefaultConnectionString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Aggregate>().HasMany(x => x.Entities1).WithOne().OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<Aggregate>().HasMany(x => x.Entities2).WithOne().OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<Aggregate>().HasMany(x => x.Entities3).WithOne().OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<Aggregate>().HasMany(x => x.Entities4).WithOne().OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<Aggregate>().HasMany(x => x.Entities5).WithOne().OnDelete(DeleteBehavior.Cascade);
    }
}