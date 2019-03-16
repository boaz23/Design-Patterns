using System;

namespace Factory.AbstractFactory.Example2.Controls.Windows {
    public class WindowsButton : IButton {
        public string Text { get; set; }

        public event EventHandler Click;

        public void Draw() => Console.WriteLine("Drawing Windows button...");
    }
}