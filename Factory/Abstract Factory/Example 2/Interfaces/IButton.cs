using System;

namespace Factory.AbstractFactory.Example2 {
    public interface IButton : IGuiControl {
        string Text { get; set; }
        event EventHandler Click;
    }
}