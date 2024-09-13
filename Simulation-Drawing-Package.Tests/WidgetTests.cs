using NUnit.Framework;
using Simulation_Drawing_Package.Widgets;

namespace Tests
{
    [TestFixture]
    public class WidgetTests
    {
        // Rectangle Tests
        [Test]
        public void Rectangle_ValidInitialization_ShouldSetProperties()
        {
            // Arrange & Act
            var rectangle = new Rectangle(10, 10, 30, 40);

            // Assert
            Assert.That(rectangle.X, Is.EqualTo(10));
            Assert.That(rectangle.Y, Is.EqualTo(10));
            Assert.That(rectangle.Width, Is.EqualTo(30));
            Assert.That(rectangle.Height, Is.EqualTo(40));
        }

        [Test]
        public void Rectangle_InvalidWidthOrHeight_ShouldThrowArgumentException()
        {
            // Assert & Act
            Assert.Throws<ArgumentException>(() => new Rectangle(10, 10, -5, 40));
            Assert.Throws<ArgumentException>(() => new Rectangle(10, 10, 30, 0));
        }

        [Test]
        public void Rectangle_Draw_ShouldReturnCorrectOutput()
        {
            // Arrange
            var rectangle = new Rectangle(10, 10, 30, 40);

            // Act & Assert
            Assert.That(rectangle.Draw(), Is.EqualTo("Rectangle (10,10) width=30 height=40"));
        }

        // Square Tests
        [Test]
        public void Square_ValidInitialization_ShouldSetProperties()
        {
            // Arrange & Act
            var square = new Square(15, 30, 35);

            // Assert
            Assert.That(square.X, Is.EqualTo(15));
            Assert.That(square.Y, Is.EqualTo(30));
            Assert.That(square.Size, Is.EqualTo(35));
        }

        [Test]
        public void Square_InvalidSize_ShouldThrowArgumentException()
        {
            // Assert & Act
            Assert.Throws<ArgumentException>(() => new Square(15, 30, -10));
        }

        [Test]
        public void Square_Draw_ShouldReturnCorrectOutput()
        {
            // Arrange
            var square = new Square(15, 30, 35);

            // Act & Assert
            Assert.That(square.Draw(), Is.EqualTo("Square (15,30) size=35"));
        }

        // Ellipse Tests
        [Test]
        public void Ellipse_ValidInitialization_ShouldSetProperties()
        {
            // Arrange & Act
            var ellipse = new Ellipse(100, 150, 300, 200);

            // Assert
            Assert.That(ellipse.X, Is.EqualTo(100));
            Assert.That(ellipse.Y, Is.EqualTo(150));
            Assert.That(ellipse.HorizontalDiameter, Is.EqualTo(300));
            Assert.That(ellipse.VerticalDiameter, Is.EqualTo(200));
        }

        [Test]
        public void Ellipse_InvalidDiameter_ShouldThrowArgumentException()
        {
            // Assert & Act
            Assert.Throws<ArgumentException>(() => new Ellipse(100, 150, -300, 200));
        }

        [Test]
        public void Ellipse_Draw_ShouldReturnCorrectOutput()
        {
            // Arrange
            var ellipse = new Ellipse(100, 150, 300, 200);

            // Act & Assert
            Assert.That(ellipse.Draw(), Is.EqualTo("Ellipse (100,150) diameterH = 300 diameterV = 200"));
        }

        // Circle Tests
        [Test]
        public void Circle_ValidInitialization_ShouldSetProperties()
        {
            // Arrange & Act
            var circle = new Circle(1, 1, 300);

            // Assert
            Assert.That(circle.X, Is.EqualTo(1));
            Assert.That(circle.Y, Is.EqualTo(1));
            Assert.That(circle.Diameter, Is.EqualTo(300));
        }

        [Test]
        public void Circle_InvalidDiameter_ShouldThrowArgumentException()
        {
            // Assert & Act
            Assert.Throws<ArgumentException>(() => new Circle(1, 1, 0));
        }

        [Test]
        public void Circle_Draw_ShouldReturnCorrectOutput()
        {
            // Arrange
            var circle = new Circle(1, 1, 300);

            // Act & Assert
            Assert.That(circle.Draw(), Is.EqualTo("Circle (1,1) size=300"));
        }

        // Textbox Tests
        [Test]
        public void Textbox_ValidInitialization_ShouldSetProperties()
        {
            // Arrange & Act
            var textbox = new Textbox(5, 5, 200, 100, "sample text");

            // Assert
            Assert.That(textbox.X, Is.EqualTo(5));
            Assert.That(textbox.Y, Is.EqualTo(5));
            Assert.That(textbox.Width, Is.EqualTo(200));
            Assert.That(textbox.Height, Is.EqualTo(100));
            Assert.That(textbox.Text, Is.EqualTo("sample text"));
        }

        [Test]
        public void Textbox_InvalidWidthOrHeight_ShouldThrowArgumentException()
        {
            // Assert & Act
            Assert.Throws<ArgumentException>(() => new Textbox(5, 5, -200, 100, "sample text"));
            Assert.Throws<ArgumentException>(() => new Textbox(5, 5, 200, 0, "sample text"));
        }

        [Test]
        public void Textbox_Draw_ShouldReturnCorrectOutput()
        {
            // Arrange
            var textbox = new Textbox(5, 5, 200, 100, "sample text");

            // Act & Assert
            Assert.That(textbox.Draw(), Is.EqualTo("Textbox (5,5) width=200 height=100 Text=\"sample text\""));
        }
    }
}