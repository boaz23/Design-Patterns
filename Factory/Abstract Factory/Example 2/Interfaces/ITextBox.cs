using System;
using System.Windows.Forms;

namespace Factory.AbstractFactory.Example2 {
    public interface ITextBox : IGuiControl {
        string Text { get; set; }
        event EventHandler TextChanged;
        event KeyPressEventHandler KeyPress;
    }
}