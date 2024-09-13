using System.Reflection;
using Microsoft.Extensions.Configuration;
using Simulation_Drawing_Package.Interfaces;

namespace Simulation_Drawing_Package.Factories
{
    public class WidgetFactory : IWidgetFactory
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly Dictionary<string, Type> _widgetTypes;

        public WidgetFactory(IServiceProvider serviceProvider, IConfiguration configuration)
        {
            _serviceProvider = serviceProvider;
            _widgetTypes = new Dictionary<string, Type>();

            var widgetMappings = configuration.GetSection("WidgetMappings").Get<Dictionary<string, string>>();

            // Assuming widgets are in the same assembly
            var assembly = Assembly.GetExecutingAssembly();

            foreach (var mapping in widgetMappings)
            {
                var typeName = mapping.Value;
                var type = assembly.GetTypes()
                                   .FirstOrDefault(t => t.Name.Equals(typeName, StringComparison.OrdinalIgnoreCase)
                                    && typeof(IWidget).IsAssignableFrom(t));

                if (type != null)
                {
                    _widgetTypes.Add(mapping.Key.ToLower(), type);
                }
                else
                {
                    throw new InvalidOperationException($"Type {typeName} could not be found or does not implement IWidget.");
                }
            }
        }

        public IWidget CreateWidget(string widgetType)
        {
            if (_widgetTypes.TryGetValue(widgetType.ToLower(), out Type widget))
            {
                return (IWidget)_serviceProvider.GetService(widget);
            }
            throw new ArgumentException("Invalid widget type");
        }
    }
}