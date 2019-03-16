using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight {
    public static class Program {
        private const int ITERATIONS_COUNT = 100;

        private static readonly string[] Colors = {
            "Red",
            "Green",
            "Blue",
            "White",
            "Black"
        };

        private static void Main(string[] args) {
            var stopwatch = Stopwatch.StartNew();

            //ExampleBefore();
            //ExampleAfter();

            stopwatch.Stop();
            Console.WriteLine($"Time elasped: {stopwatch.ElapsedMilliseconds}ms");
        }

        private static void ExampleBefore() {
            for (int i = 0; i < ITERATIONS_COUNT; ++i) {
                Before.Circle circle = new Before.Circle(GetRandomColor(), GetRandomPoint(), GetRandomRadius());
                circle.Draw();
            }
        }
        private static void ExampleAfter() {
            for (int i = 0; i < ITERATIONS_COUNT; ++i) {
                After.Circle circle = After.Circle.GetCircle(GetRandomColor());
                circle.Draw(GetRandomPoint(), GetRandomRadius());
            }
        }

        private static string GetRandomColor() {
            return Colors[new Random().Next(0, Colors.Length)];
        }
        private static Point GetRandomPoint() {
            var random = new Random();
            return new Point(random.Next(0, 101), random.Next(0, 101));
        }
        private static int GetRandomRadius() {
            return new Random().Next(1, 26);
        }
    }
}