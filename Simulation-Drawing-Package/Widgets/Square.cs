using System;
using Simulation_Drawing_Package.Interfaces;

namespace Simulation_Drawing_Package.Widgets
{
    public class Square : IWidget
    {
        public int X { get; }
        public int Y { get; }
        public int Size { get; }

        public Square(int x, int y, int size)
        {
            if (size <= 0) throw new ArgumentException("Size must be positive.");
            X = x;
            Y = y;
            Size = size;
        }

        public string Draw()
        {
            return $"Square ({X},{Y}) size={Size}";
        }
    }
}

