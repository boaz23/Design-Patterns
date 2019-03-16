using System;
using System.Drawing;
using System.Threading;

namespace Flyweight.Before {
    public class Circle {
        public Circle(string color, Point point, int radius) {
            this.Color = color;
            this.Point = point;
            this.Radius = radius;

            Thread.Sleep(100);
        }

        public string Color { get; }
        public Point Point { get; }
        public int Radius { get; }

        public void Draw() {
            Console.WriteLine($"Drawing circle with radius {this.Radius} and color {this.Color} at ({this.Point.X}, {this.Point.Y})...");
        }
    }
}