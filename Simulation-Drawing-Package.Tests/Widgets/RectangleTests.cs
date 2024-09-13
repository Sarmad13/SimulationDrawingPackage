using Simulation_Drawing_Package.Widgets;

namespace Tests.Widgets
{
    [TestFixture]
    public class RectangleTests
    {
        [Test]
        public void Rectangle_ValidInitialization_ShouldSetProperties()
        {
            var rectangle = new Rectangle(10, 10, 30, 40);

            Assert.That(rectangle.X, Is.EqualTo(10));
            Assert.That(rectangle.Y, Is.EqualTo(10));
            Assert.That(rectangle.Width, Is.EqualTo(30));
            Assert.That(rectangle.Height, Is.EqualTo(40));
        }

        [Test]
        public void Rectangle_InvalidWidthOrHeight_ShouldThrowArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Rectangle(10, 10, -5, 40));
            Assert.Throws<ArgumentException>(() => new Rectangle(10, 10, 30, 0));
        }

        [Test]
        public void Rectangle_Draw_ShouldReturnCorrectOutput()
        {
            var rectangle = new Rectangle(10, 10, 30, 40);

            Assert.That(rectangle.Draw(), Is.EqualTo("Rectangle (10,10) width=30 height=40"));
        }
    }
}