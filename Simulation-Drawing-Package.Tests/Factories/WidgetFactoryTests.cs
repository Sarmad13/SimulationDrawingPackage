using Simulation_Drawing_Package.Config;
using Simulation_Drawing_Package.Factories;
using Simulation_Drawing_Package.Widgets;

namespace Tests.Factories
{
    [TestFixture]
    public class WidgetFactoryTests
    {
        private WidgetFactory _factory;

        [SetUp]
        public void Setup()
        {
            _factory = new WidgetFactory();
        }

        [Test]
        public void CreateRectangleWidget_ValidConfig_ReturnsRectangleWidget()
        {
            var config = new WidgetConfig { Type = "rectangle", X = 10, Y = 10, Width = 30, Height = 40 };
            var widget = _factory.CreateWidget(config);

            Assert.That(widget, Is.InstanceOf<Rectangle>());
        }

        [Test]
        public void CreateInvalidWidgetType_ThrowsArgumentException()
        {
            var config = new WidgetConfig { Type = "invalid" };
            Assert.Throws<ArgumentException>(() => _factory.CreateWidget(config));
        }
    }
}