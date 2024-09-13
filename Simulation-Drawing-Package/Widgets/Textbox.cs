using System;
using Simulation_Drawing_Package.Interfaces;

namespace Simulation_Drawing_Package.Widgets
{
    public class Textbox : IWidget
    {
        public int X { get; }
        public int Y { get; }
        public int Width { get; }
        public int Height { get; }
        public string Text { get; }

        public Textbox(int x, int y, int width, int height, string text)
        {
            if (width <= 0 || height <= 0) throw new ArgumentException("Dimensions must be positive.");
            X = x;
            Y = y;
            Width = width;
            Height = height;
            Text = text ?? string.Empty;
        }

        public string Draw()
        {
            return $"Textbox ({X},{Y}) width={Width} height={Height} Text=\"{Text}\"";
            //Console.WriteLine($"Textbox ({X},{Y}) width={Width} height={Height} Text=\"{Text}\"");
        }
    }
}

