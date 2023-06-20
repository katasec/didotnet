

// Create App Host
using Lesson01;

using var host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((hostContext, services) =>
    {
        services.AddTransient<HappyHello>();
        services.AddTransient<IHello,SadHello>();
        services.AddTransient<Greeter>();
    })
.Build();

// Get a Greeter. Note the DI container will resolve the dependencies, in this case IHello
var happyHello = host.Services.GetRequiredService<Greeter>();

happyHello.Greet();

