using Simulation_Drawing_Package.Interfaces;

namespace Simulation_Drawing_Package
{
    public class DrawingApp
    {
        private readonly IWidgetFactory _widgetFactory;

        public DrawingApp(IWidgetFactory widgetFactory)
        {
            _widgetFactory = widgetFactory;
        }

        public void Run()
        {
            var widgets = new IWidget[]
            {
            _widgetFactory.CreateWidget("rectangle"),
            _widgetFactory.CreateWidget("square"),
            _widgetFactory.CreateWidget("ellipse"),
            _widgetFactory.CreateWidget("circle"),
            _widgetFactory.CreateWidget("textbox"),
            };

            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("Requested Drawing");
            Console.WriteLine("----------------------------------------------------------------");

            foreach (var widget in widgets)
            {
                Console.WriteLine(widget.Draw());
            }

            Console.WriteLine("----------------------------------------------------------------");
        }
    }
}

