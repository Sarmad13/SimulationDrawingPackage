using Simulation_Drawing_Package.Widgets;

namespace Tests.Widgets
{
    [TestFixture]
    public class EllipseTests
    {
        [Test]
        public void Ellipse_ValidInitialization_ShouldSetProperties()
        {
            var ellipse = new Ellipse(100, 150, 300, 200);

            Assert.That(ellipse.X, Is.EqualTo(100));
            Assert.That(ellipse.Y, Is.EqualTo(150));
            Assert.That(ellipse.HorizontalDiameter, Is.EqualTo(300));
            Assert.That(ellipse.VerticalDiameter, Is.EqualTo(200));
        }

        [Test]
        public void Ellipse_InvalidDiameter_ShouldThrowArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Ellipse(100, 150, -300, 200));
        }

        [Test]
        public void Ellipse_Draw_ShouldReturnCorrectOutput()
        {
            var ellipse = new Ellipse(100, 150, 300, 200);

            Assert.That(ellipse.Draw(), Is.EqualTo("Ellipse (100,150) diameterH = 300 diameterV = 200"));
        }
    }
}