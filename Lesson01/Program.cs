using Microsoft.Extensions.Logging;


// Create App Host
using Lesson01.Greeter;

using var host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((hostContext, services) =>
    {
        services.AddTransient<HappyHello>();
        services.AddTransient<IHello,HappyHello>();
        services.AddTransient<Greeter>();
    })
    .ConfigureLogging(logging =>
    {
        logging.ClearProviders();
        logging.AddConsole();
    })
.Build();

// Get a Greeter. Note the DI container will resolve the dependencies, in this case IHello
var happyHello = host.Services.GetRequiredService<Greeter>();

happyHello.Greet();

