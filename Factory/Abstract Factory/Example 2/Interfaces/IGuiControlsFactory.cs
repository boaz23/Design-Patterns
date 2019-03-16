namespace Factory.AbstractFactory.Example2 {
    public interface IGuiControlsFactory {
        IButton CreateButton();
        ITextBox CreateTextBox();
    }
}