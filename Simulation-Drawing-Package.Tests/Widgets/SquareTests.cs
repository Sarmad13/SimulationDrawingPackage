using Simulation_Drawing_Package.Widgets;

namespace Tests.Widgets
{
    [TestFixture]
    public class SquareTests
    {
        [Test]
        public void Square_ValidInitialization_ShouldSetProperties()
        {
            var square = new Square(15, 30, 35);

            Assert.That(square.X, Is.EqualTo(15));
            Assert.That(square.Y, Is.EqualTo(30));
            Assert.That(square.Size, Is.EqualTo(35));
        }

        [Test]
        public void Square_InvalidSize_ShouldThrowArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Square(15, 30, -10));
        }

        [Test]
        public void Square_Draw_ShouldReturnCorrectOutput()
        {
            var square = new Square(15, 30, 35);

            Assert.That(square.Draw(), Is.EqualTo("Square (15,30) size=35"));
        }
    }
}