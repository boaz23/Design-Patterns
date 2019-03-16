namespace Adapter.Example1 {
    // Adapter
    public class DviToVgaAdapter : IVgaSocket {
        public IDviSocket DviSocket { get; set; }

        public byte[,][] GetScreenBuffer() {
            byte[,][] buffer = this.DviSocket.GetScreenBuffer();

            // Adapt the buffer to be compatible with VGA here
            // ...
            // Return the new buffer

            return buffer;
        }
    }
}