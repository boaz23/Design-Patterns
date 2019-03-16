using System;
using System.Windows.Forms;

namespace Factory.AbstractFactory.Example2.Controls.Windows {
    public class WindowsTextBox : ITextBox {
        public string Text { get; set; }

        public event EventHandler TextChanged;
        public event KeyPressEventHandler KeyPress;

        public void Draw() => Console.WriteLine("Drwaing Windows text box...");
    }
}