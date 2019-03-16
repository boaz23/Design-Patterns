using System;
using System.Drawing;

namespace Composite {
    // Leaf
    public class Ellipse : IGraphic {
        public Ellipse(Point center, int a, int b) {
            this.Center = center;
            this.A = a;
            this.B = b;
        }

        public Point Center { get; }
        public int A { get; }
        public int B { get; }

        public void Draw() {
            Console.WriteLine($"Drawing ellipse at ({this.Center.X}, {this.Center.Y}) with semi-major and semi-minor axes of ({this.A}, {this.B})");
        }
    }
}