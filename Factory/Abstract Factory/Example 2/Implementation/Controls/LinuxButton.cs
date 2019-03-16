using System;

namespace Factory.AbstractFactory.Example2.Controls.Linux {
    public class LinuxButton : IButton {
        public string Text { get; set; }

        public event EventHandler Click;

        public void Draw() => Console.WriteLine("Drawing Linux button...");
    }
}