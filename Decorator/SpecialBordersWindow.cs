using System;
using System.Drawing;

namespace Decorator {
    public class SpecialBordersWindow : WindowDecorator {
        public SpecialBordersWindow(IWindow window) : base(window) { }

        public Color Color { get; set; }
        public string Shape { get; set; }
        public int Thickness { get; set; }

        public override void Draw() {
            base.Draw();
            this.DrawBorders();
        }

        protected virtual void DrawBorders() {
            Console.WriteLine($"Drawing special borders of color {this.Color}, shape {this.Shape} and thickness {this.Thickness}...");
        }
    }
}