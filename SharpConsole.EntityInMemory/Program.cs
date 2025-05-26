using Microsoft.EntityFrameworkCore;
using SharpConsole.Core.Application;
using SharpConsole.Core.Domain.Entities;
using SharpConsole.Entity.InMemory.Infrastructure;

var options = new DbContextOptionsBuilder<AppDbContext>()
    .UseInMemoryDatabase(databaseName: "TestDb")
    .Options;

var dbContext = new AppDbContext(options);

// Add some test data
dbContext.Users.Add(new User { Name = "John Doe", Age = 30 });
dbContext.Users.Add(new User { Name = "Jane Smith", Age = 25 });
await dbContext.SaveChangesAsync();

var console = new EntityConsole()
{
  db = dbContext
};

console.Start();

public class EntityConsole : SharpConsoleBase
{
  public AppDbContext? db { get; set; }

}
