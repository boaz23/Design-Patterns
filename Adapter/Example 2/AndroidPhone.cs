using System;
using System.Threading;
using System.Threading.Tasks;

namespace Adapter.Example2 {
    /// <summary>
    /// Represents an android phone, this class has no role, it's just to make some sense
    /// </summary>
    public class AndroidPhone {
        public AndroidPhone() {
            this.Battery = 0;
        }

        public double Battery { get; private set; }

        /// <summary>
        /// Recharges the phone
        /// </summary>
        /// <param name="cable">The USB cable pluged in to the phone</param>
        /// <param name="cancellationToken">Respresents the act of pulling the cable from the phone or the adapter from the wall socket, thus stopping the recharging</param>
        public async Task Recharge(AndroidUsbCable cable, CancellationToken cancellationToken) {
            await Task.Run(() => {
                while (!cancellationToken.IsCancellationRequested && this.Battery < 100) {
                    int electricity = cable.ProvideElectricity(); // get electricity from the usb cable
                    this.Battery += (double)electricity / 150; // recharge 1% per 30s
                    Console.WriteLine($"Recharging ({this.Battery:F}%)...");

                    if (cancellationToken.IsCancellationRequested) {
                        break;
                    }
                    Thread.Sleep(200); // wait 200ms
                }
            }, cancellationToken);
        }
    }
}