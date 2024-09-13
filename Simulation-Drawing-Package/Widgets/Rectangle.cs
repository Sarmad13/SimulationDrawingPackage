using System;
using Simulation_Drawing_Package.Interfaces;

namespace Simulation_Drawing_Package.Widgets
{
    public class Rectangle : IWidget
    {
        public int X { get; }
        public int Y { get; }
        public int Width { get; }
        public int Height { get; }

        public Rectangle(int x, int y, int width, int height)
        {
            if (width <= 0 || height <= 0) throw new ArgumentException("Dimensions must be positive.");
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }

        public string Draw()
        {
            return $"Rectangle ({X},{Y}) width={Width} height={Height}";
        }
    }
}

