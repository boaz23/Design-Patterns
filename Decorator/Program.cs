using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator {
    public static class Program {
        private static void Main(string[] args) {
            Example();
        }

        private static void Example() {
            IWindow originalWindow = new Window();

            // notice how we're stacking decorators on top of each other
            WindowDecorator window = new SpecialBordersWindow(new ScrollableWindow(originalWindow)) {
                Title = "My Decorated Window",
                Color = Color.Green,
                Shape = "Star",
                Thickness = 2
            };

            window.Draw();
            window.Title = "New Title";

            Console.WriteLine();
            originalWindow.Draw(); // notice how the new title is still in effect
        }
    }
}