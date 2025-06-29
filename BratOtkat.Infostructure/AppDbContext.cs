using BratOtkat.Domain;
using BratOtkat.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace BratOtkat.Infostructure;

public sealed class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        Database.EnsureCreated();
    }


    // DbSet properties for your entities
    public DbSet<Position> Positions { get; set; }
}