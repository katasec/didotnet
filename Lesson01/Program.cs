

// Create App Host
using Lesson01;

using var host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((hostContext, services) =>
    {
        services.AddTransient<HappyHello>();
    })
.Build();

// Get a Happy Hello Object
var happyHello = host.Services.GetRequiredService<HappyHello>();
