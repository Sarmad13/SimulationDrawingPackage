using Microsoft.Extensions.Options;
using Simulation_Drawing_Package.Config;
using Simulation_Drawing_Package.Factories;
using Simulation_Drawing_Package.Interfaces;

namespace Simulation_Drawing_Package
{
    public class DrawingApp
    {
        private readonly DrawingContext _drawingContext;
        private readonly IWidgetFactory _widgetFactory;
        private readonly List<WidgetConfig> _widgetConfigs;

        public DrawingApp(DrawingContext drawingContext, IWidgetFactory widgetFactory, IOptions<List<WidgetConfig>> widgetConfigs)
        {
            _drawingContext = drawingContext;
            _widgetFactory = widgetFactory;
            _widgetConfigs = widgetConfigs.Value;
        }

        public void Run()
        {
            foreach (var widgetConfig in _widgetConfigs)
            {
                var widget = _widgetFactory.CreateWidget(widgetConfig);
                _drawingContext.AddWidget(widget);
            }

            _drawingContext.PrintAllWidgets();
        }
    }
}

