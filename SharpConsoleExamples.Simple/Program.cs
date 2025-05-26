using SharpConsole.Core.Application;
using SharpConsole.Core.Domain.Entities;

var console = new SimpleConsole
{
  Name = "Simple Example",
  Tags = new[] { "tag1", "tag2" },
  Version = 1
};

console.Start();

public class SimpleConsole : SharpConsoleBase
{
  public string? Name { get; set; }
  public int? Version { get; set; }
  public string[]? Tags { get; set; }
}
