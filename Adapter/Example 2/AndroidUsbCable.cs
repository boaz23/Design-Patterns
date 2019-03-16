namespace Adapter.Example2 {
    /// <summary>
    /// Client: Connects the android phone to power source that provides electricity to a USB cable
    /// The client chooses to deliver the output he got from the USB power source to the android phone
    /// </summary>
    public class AndroidUsbCable {
        public IUsbPowerSource UsbPowerSource { get; set; }

        /// <summary>
        /// Delivers the electricity got from the power source compatible to a USB cable to an android phone
        /// </summary>
        /// <returns></returns>
        public int ProvideElectricity() {
            return this.UsbPowerSource.ProvideElectricity();
        }
    }
}