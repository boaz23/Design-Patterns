using System;

namespace Decorator {
    public interface IWindow {
        void Draw();
        string Title { get; set; }
    }

    public class Window : IWindow {
        public void Draw() {
            Console.WriteLine($"Drawing window {this.Title}...");
        }

        public string Title { get; set; }
    }
}