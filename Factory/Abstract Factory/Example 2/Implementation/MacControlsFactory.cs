using Factory.AbstractFactory.Example2.Controls.Mac;

namespace Factory.AbstractFactory.Example2 {
    public class MacControlsFactory : IGuiControlsFactory {
        public IButton CreateButton() => new MacButton();
        public ITextBox CreateTextBox() => new MacTextBox();
    }
}