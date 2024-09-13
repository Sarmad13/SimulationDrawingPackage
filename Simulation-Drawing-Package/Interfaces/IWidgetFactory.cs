using Simulation_Drawing_Package.Config;
namespace Simulation_Drawing_Package.Interfaces
{
    public interface IWidgetFactory
    {
        IWidget CreateWidget(WidgetConfig widgetType);
    }
}

