using System;
using System.Windows.Forms;

namespace Factory.AbstractFactory.Example2.Controls.Linux {
    public class LinuxTextBox : ITextBox {
        public string Text { get; set; }

        public event EventHandler TextChanged;
        public event KeyPressEventHandler KeyPress;

        public void Draw() => Console.WriteLine("Drwaing Linux text box...");
    }
}