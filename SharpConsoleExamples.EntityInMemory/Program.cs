using Microsoft.EntityFrameworkCore;
using SharpConsole.Core.Application;

using SharpConsoleExamples.EntityInMemory.Infrastructure;

var options = new DbContextOptionsBuilder<AppDbContext>()
    .UseInMemoryDatabase(databaseName: "TestDb")
    .Options;

var dbContext = new AppDbContext(options);

// Add some test data
dbContext.Users.Add(new User { Name = "John Doe", Age = 30 });
dbContext.Users.Add(new User { Name = "Jane Smith", Age = 25 });
await dbContext.SaveChangesAsync();

var context = new EntityConsoleContext()
{
  db = dbContext
};

context.StartConsole();

public class EntityConsoleContext : ConsoleContext
{
  public AppDbContext? db { get; set; }
}
