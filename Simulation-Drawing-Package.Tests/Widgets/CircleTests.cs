using Simulation_Drawing_Package.Widgets;

namespace Tests.Widgets
{
    [TestFixture]
    public class CircleTests
    {
        [Test]
        public void Circle_ValidInitialization_ShouldSetProperties()
        {
            var circle = new Circle(1, 1, 300);

            Assert.That(circle.X, Is.EqualTo(1));
            Assert.That(circle.Y, Is.EqualTo(1));
            Assert.That(circle.Diameter, Is.EqualTo(300));
        }

        [Test]
        public void Circle_InvalidDiameter_ShouldThrowArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Circle(1, 1, 0));
        }

        [Test]
        public void Circle_Draw_ShouldReturnCorrectOutput()
        {
            var circle = new Circle(1, 1, 300);

            Assert.That(circle.Draw(), Is.EqualTo("Circle (1,1) size=300"));
        }
    }
}