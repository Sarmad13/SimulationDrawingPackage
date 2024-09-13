using System;
using Simulation_Drawing_Package.Interfaces;

namespace Simulation_Drawing_Package.Widgets
{
    public class Ellipse : IWidget
    {
        public int X { get; }
        public int Y { get; }
        public int HorizontalDiameter { get; }
        public int VerticalDiameter { get; }

        public Ellipse(int x, int y, int horizontalDiameter, int verticalDiameter)
        {
            if (horizontalDiameter <= 0 || verticalDiameter <= 0)
                throw new ArgumentException("Diameters must be positive.");
            X = x;
            Y = y;
            HorizontalDiameter = horizontalDiameter;
            VerticalDiameter = verticalDiameter;
        }

        public string Draw()
        {
            return $"Ellipse ({X},{Y}) diameterH = {HorizontalDiameter} diameterV = {VerticalDiameter}";
            //Console.WriteLine($"Ellipse ({X},{Y}) diameterH = {HorizontalDiameter} diameterV = {VerticalDiameter}");
        }
    }
}

