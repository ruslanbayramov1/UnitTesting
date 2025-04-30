using ConsoleApp.Services.Implements;
using ConsoleApp.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();
services.AddScoped<IOperationService, OperationService>();
var provider = services.BuildServiceProvider();

var operationService = provider.GetRequiredService<IOperationService>();
int res = operationService.SumArr([1, 2, 3, 4, 5, 6, 7, 8, 9]);
Console.WriteLine(res);