using System;

namespace Decorator {
    public class ScrollableWindow : WindowDecorator {
        public ScrollableWindow(IWindow window) : base(window) { }

        public override void Draw() {
            base.Draw();
            this.DrawScrollbars();
        }

        protected virtual void DrawScrollbars() {
            Console.WriteLine("Drawing scrollbars...");
        }
    }
}