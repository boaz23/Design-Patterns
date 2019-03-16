namespace Adapter.Example2 {
    /// <summary>
    /// Adaptee: Represents a power source that provides electricity to a plug
    /// </summary>
    public interface IWallSocketPowerSource {
        int ProvideElectricity();
    }
}