namespace Adapter.Example2 {
    /// <summary>
    /// Adapter: The adapter used to connect to the wall socket and that has a USB socket on it's other end, thus providing the USB cable electricity it gets from the wall socket
    /// </summary>
    public class WallSocketToUsbPowerSourceAdapter : IUsbPowerSource {
        public IWallSocketPowerSource WallSocketPowerSource { get; set; }

        public int ProvideElectricity() {
            int electricity = this.WallSocketPowerSource.ProvideElectricity(); // get electricity from the wall socket
            return electricity / 44; // should return 5v
        }
    }
}