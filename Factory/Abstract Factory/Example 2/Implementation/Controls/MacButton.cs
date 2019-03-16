using System;

namespace Factory.AbstractFactory.Example2.Controls.Mac {
    public class MacButton : IButton {
        public string Text { get; set; }

        public event EventHandler Click;

        public void Draw() => Console.WriteLine("Drawing Mac button...");
    }
}