using Microsoft.Extensions.Logging;

namespace Lesson01.Greeter;

public class SadHello : IHello
{
    ILogger<SadHello> _logger;

    public SadHello(ILogger<SadHello> logger)
    {
        _logger = logger;
    }
    public void SayHello(string name)
    {
        _logger.LogInformation($"Hello {name}! I'm Sad!");
        //Console.WriteLine($"Hello {name}! I'm Sad!");
    }
}
