using Microsoft.Extensions.DependencyInjection;
using Simulation_Drawing_Package;
using Simulation_Drawing_Package.Factories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Simulation_Drawing_Package.Config;
using Simulation_Drawing_Package.Interfaces;

var host = Host.CreateDefaultBuilder(args)
            .ConfigureAppConfiguration((context, config) =>
            {
                config.AddJsonFile("Settings/appsettings.json", optional: false, reloadOnChange: true);
            })
            .ConfigureServices((context, services) =>
            {
                services.AddSingleton<IWidgetFactory, WidgetFactory>();
                services.AddSingleton<DrawingContext>();
                services.AddTransient<DrawingApp>();

                services.Configure<List<WidgetConfig>>(context.Configuration.GetSection("Widgets"));
            })
            .Build();

host.Services.GetRequiredService<DrawingApp>().Run();
Console.Read();
