using BaseProject.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace BaseProject.Backend.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Country> countries { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Country>().HasIndex(x => x.Name).IsUnique();
    }
}