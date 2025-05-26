using Microsoft.EntityFrameworkCore;

namespace SharpConsole.Entity.InMemory.Infrastructure;

public class AppDbContext : DbContext
{
  public DbSet<User> Users { get; set; }

  public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
  {
  }
}
