using System;
using System.Drawing;

namespace Composite {
    // Leaf
    public class Rectangle : IGraphic {
        public Rectangle(Point upperLeft, Size size) {
            this.UpperLeft = upperLeft;
            this.Size = size;
        }

        public Point UpperLeft { get; }
        public Size Size { get; }

        public void Draw() {
            Console.WriteLine($"Drawing rectangle at ({this.UpperLeft.X}, {this.UpperLeft.Y}) with width {this.Size.Width} and height {this.Size.Height}");
        }
    }
}