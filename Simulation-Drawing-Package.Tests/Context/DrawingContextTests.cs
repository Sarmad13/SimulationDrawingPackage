using Simulation_Drawing_Package;
using Simulation_Drawing_Package.Widgets;

namespace Tests.Context
{
    [TestFixture]
    public class DrawingContextTests
    {
        private DrawingContext _context;

        [SetUp]
        public void Setup()
        {
            _context = new DrawingContext();
        }

        [Test]
        public void AddWidget_WidgetIsAddedToContext()
        {
            var widget = new Rectangle(10, 10, 30, 40);
            _context.AddWidget(widget);

            var widgets = _context.GetWidgets();

            Assert.That(widgets, Does.Contain(widget));
        }
    }
}