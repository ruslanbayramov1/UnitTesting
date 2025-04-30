using ConsoleApp.Services.Implements;
using ConsoleApp.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace ConsoleApp.Tests;

public static class ServiceRegistration
{
    public static IServiceProvider Configure()
    {
        var services = new ServiceCollection();
        services.AddScoped<IOperationService, OperationService>();
        return services.BuildServiceProvider();
    }
}
