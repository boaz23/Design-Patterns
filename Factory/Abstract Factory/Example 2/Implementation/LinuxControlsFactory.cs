using Factory.AbstractFactory.Example2.Controls.Linux;

namespace Factory.AbstractFactory.Example2 {
    public class LinuxControlsFactory : IGuiControlsFactory {
        public IButton CreateButton() => new LinuxButton();
        public ITextBox CreateTextBox() => new LinuxTextBox();
    }
}