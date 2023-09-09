using Microsoft.EntityFrameworkCore;
using GetYourDrink.Data.Models;

namespace GetYourDrink.Data.DataContext;

public partial class GetYourDrinkContext : DbContext
{
    public GetYourDrinkContext()
    {
    }

    public GetYourDrinkContext(DbContextOptions<GetYourDrinkContext> options)
        : base(options)
    {
    }

    public virtual DbSet<User> Users { get; set; } 

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Favourite> Favourite { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=.;Database=GetYourDrink;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {       
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
