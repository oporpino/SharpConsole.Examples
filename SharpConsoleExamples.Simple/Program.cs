using SharpConsole.Core.Application;

var context = new SimpleConsoleContext
{
  Name = "Simple Example",
  Tags = new[] { "tag1", "tag2" },
  Version = 1
};

context.StartConsole();

public class SimpleConsoleContext : ConsoleContext
{
  public string? Name { get; set; }
  public int? Version { get; set; }
  public string[]? Tags { get; set; }
}
