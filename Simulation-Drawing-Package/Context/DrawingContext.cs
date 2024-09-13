using Simulation_Drawing_Package.Interfaces;

namespace Simulation_Drawing_Package
{
    public class DrawingContext
    {
        private readonly List<IWidget> _widgets = new();

        public void AddWidget(IWidget widget)
        {
            _widgets.Add(widget);
        }

        public void PrintAllWidgets()
        {
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("Requested Drawing");
            Console.WriteLine("----------------------------------------------------------------");

            foreach (var widget in _widgets)
            {
                Console.WriteLine(widget.Draw());
            }

            Console.WriteLine("----------------------------------------------------------------");
        }

        public List<IWidget> GetWidgets()
        {
            return _widgets;
        }
    }
}

