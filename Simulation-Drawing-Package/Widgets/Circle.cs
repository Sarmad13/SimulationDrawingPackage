using System;
using Simulation_Drawing_Package.Interfaces;

namespace Simulation_Drawing_Package.Widgets
{
    public class Circle : IWidget
    {
        public int X { get; }
        public int Y { get; }
        public int Diameter { get; }

        public Circle(int x, int y, int diameter)
        {
            if (diameter <= 0) throw new ArgumentException("Diameter must be positive.");
            X = x;
            Y = y;
            Diameter = diameter;
        }

        public string Draw()
        {
            return $"Circle ({X},{Y}) size={Diameter}";
        }
    }
}

