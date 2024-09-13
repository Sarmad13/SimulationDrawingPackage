using Microsoft.Extensions.DependencyInjection;
using Simulation_Drawing_Package;
using Simulation_Drawing_Package.Factories;
using Simulation_Drawing_Package.Interfaces;
using Simulation_Drawing_Package.Widgets;
using Microsoft.Extensions.Configuration;

var configuration = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .Build();

var serviceProvider = new ServiceCollection()
    .AddSingleton<IConfiguration>(configuration)
    .AddTransient(provider => new Rectangle(10, 10, 30, 40))
    .AddTransient(provider => new Square(15, 30, 35))
    .AddTransient(provider => new Ellipse(100, 150, 300, 200))
    .AddTransient(provider => new Circle(1, 1, 300))
    .AddTransient(provider => new Textbox(5, 5, 200, 100, "sample text"))
    .AddSingleton<IWidgetFactory, WidgetFactory>()
    .BuildServiceProvider();

// Resolve and run the application
var app = new DrawingApp(serviceProvider.GetService<IWidgetFactory>());
app.Run();
Console.Read();
