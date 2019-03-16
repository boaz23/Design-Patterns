namespace Adapter.Example2 {
    /// <summary>
    /// An implementation of <see cref="IWallSocketPowerSource"/>
    /// </summary>
    public class WallSocketPowerSource : IWallSocketPowerSource {
        public int ProvideElectricity() => 220; // A wall socket that gives 220v (volts)
    }
}