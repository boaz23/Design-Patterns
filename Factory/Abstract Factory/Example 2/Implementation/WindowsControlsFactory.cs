using Factory.AbstractFactory.Example2.Controls.Windows;

namespace Factory.AbstractFactory.Example2 {
    public class WindowsControlsFactory : IGuiControlsFactory {
        public IButton CreateButton() => new WindowsButton();
        public ITextBox CreateTextBox() => new WindowsTextBox();
    }
}