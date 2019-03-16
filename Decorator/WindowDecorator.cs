using System;

namespace Decorator {
    public abstract class WindowDecorator : IWindow {
        public WindowDecorator(IWindow window) {
            this.Window = window;
        }

        public IWindow Window { get; }

        public string Title {
            get {
                return this.Window.Title;
            }
            set {
                this.Window.Title = value;
            }
        }

        public virtual void Draw() {
            Console.Write("Decorated: ");
            this.Window.Draw();
        }
    }
}