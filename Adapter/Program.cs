using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Adapter.Example1;
using Adapter.Example2;

namespace Adapter {
    public static class Program {
        private static void Main(string[] args) {

        }

        private static void Example1() {
            IVgaSocket dviToVgaSocketAdapter = new DviToVgaAdapter {
                DviSocket = new DviSocket()
            };

            // Client code
            byte[,][] vgaScreenBuffer = dviToVgaSocketAdapter.GetScreenBuffer();
        }

        private static void Example2() {
            var androidPhone = new AndroidPhone();
            var androidUsbCable = new AndroidUsbCable {
                UsbPowerSource = new WallSocketToUsbPowerSourceAdapter {
                    WallSocketPowerSource = new WallSocketPowerSource()
                }
            };
            var cts = new CancellationTokenSource();
            Task task = androidPhone.Recharge(androidUsbCable, cts.Token).ContinueWith(
                t => Console.WriteLine(androidPhone.Battery)
            );
            cts.CancelAfter(10000);
            task.Wait();
        }
    }
}