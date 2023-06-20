
# Adding DI container

Add package:

```powershell
 dotnet add package microsoft.extensions.hosting
```

Add usings:

```csharp
global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.Extensions.Hosting;
```

Build a host:
```csharp
// Create App Host
using var host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((hostContext, services) =>
    {
        // Add Classes with DI container
    })
    .Build();
```

Get registered object:

```csharp
var happyHello = host.Services.GetRequiredService<HappyHello>();
```