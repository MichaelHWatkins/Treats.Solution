using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

using Microsoft.EntityFrameworkCore;

namespace Treats.Models
{
  public class TreatsContext : IdentityDbContext<ApplicationUser>
  {
    public DbSet<Sweet> Sweets { get; set; }
    public DbSet<Flavor> Flavors { get; set; }
    public DbSet<SweetFlavor> CategoryItem { get; set; }

    public TreatsContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}