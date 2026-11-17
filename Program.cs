using Microsoft.Extensions.DependencyInjection;
using VERRA_Wordlist.Business;
using VERRA_Wordlist.Business.Interfaces;

var services = new ServiceCollection();

services.AddTransient<IFileManager, FileManager>();
services.AddTransient<InitApplication>();

using var serviceProvider = services.BuildServiceProvider();

var app = serviceProvider.GetRequiredService<InitApplication>();
app.Run();


//Console.WriteLine("Hello, World!");

