using Microsoft.Extensions.Logging;

namespace Lesson01.Greeter;

public class HappyHello : IHello
{
    ILogger<HappyHello> _logger;

    public HappyHello(ILogger<HappyHello> logger)
    {
        _logger = logger;
    }

    public void SayHello(string name)
    {
        _logger.LogInformation($"Hello {name}! I'm Happy!");
    }
}
