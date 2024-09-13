using Simulation_Drawing_Package.Config;
using Simulation_Drawing_Package.Interfaces;
using Simulation_Drawing_Package.Widgets;

namespace Simulation_Drawing_Package.Factories
{
    public class WidgetFactory : IWidgetFactory
    {
        public IWidget CreateWidget(WidgetConfig config) => config.Type.ToLower() switch
        {
            "rectangle" => new Rectangle(config.X, config.Y, (int)config.Width, (int)config.Height),
            "square" => new Square(config.X, config.Y, (int)config.Size),
            "ellipse" => new Ellipse(config.X, config.Y, (int)config.HorizontalDiameter, (int)config.VerticalDiameter),
            "circle" => new Circle(config.X, config.Y, (int)config.Size),
            "textbox" => new Textbox(config.X, config.Y, (int)config.Width, (int)config.Height, config.Text),
            _ => throw new ArgumentException("Invalid widget type")
        };
    }
}