using System;
using System.Windows.Forms;

namespace Factory.AbstractFactory.Example2.Controls.Mac {
    public class MacTextBox : ITextBox {
        public string Text { get; set; }

        public event EventHandler TextChanged;
        public event KeyPressEventHandler KeyPress;

        public void Draw() => Console.WriteLine("Drwaing Mac text box...");
    }
}