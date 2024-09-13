using Simulation_Drawing_Package.Widgets;

namespace Tests.Widgets
{
    [TestFixture]
    public class TextboxTests
    {
        [Test]
        public void Textbox_ValidInitialization_ShouldSetProperties()
        {
            var textbox = new Textbox(5, 5, 200, 100, "sample text");

            Assert.That(textbox.X, Is.EqualTo(5));
            Assert.That(textbox.Y, Is.EqualTo(5));
            Assert.That(textbox.Width, Is.EqualTo(200));
            Assert.That(textbox.Height, Is.EqualTo(100));
            Assert.That(textbox.Text, Is.EqualTo("sample text"));
        }

        [Test]
        public void Textbox_InvalidWidthOrHeight_ShouldThrowArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Textbox(5, 5, -200, 100, "sample text"));
            Assert.Throws<ArgumentException>(() => new Textbox(5, 5, 200, 0, "sample text"));
        }

        [Test]
        public void Textbox_Draw_ShouldReturnCorrectOutput()
        {
            var textbox = new Textbox(5, 5, 200, 100, "sample text");

            Assert.That(textbox.Draw(), Is.EqualTo("Textbox (5,5) width=200 height=100 Text=\"sample text\""));
        }
    }
}