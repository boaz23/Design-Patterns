using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;

namespace Flyweight.After {
    public class Circle {
        private static Dictionary<string, Circle> Cache;

        static Circle() {
            Cache = new Dictionary<string, Circle>();
        }

        private Circle(string color) {
            this.Color = color;
            Console.WriteLine($"Creating circle with color {color}");

            Thread.Sleep(100);
        }

        public string Color { get; }

        public void Draw(Point point, int radius) {
            Console.WriteLine($"Drawing circle with radius {radius} and color {this.Color} at ({point.X}, {point.Y})...");
        }

        public static Circle GetCircle(string color) {
            Circle circle;
            if (Cache.TryGetValue(color, out circle)) {
                return circle;
            }

            circle = new Circle(color);
            Cache.Add(color, circle);
            return circle;
        }
    }
}