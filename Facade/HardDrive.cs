namespace Facade {
    public class HardDrive {
        public byte[] Read(long lba, int size) {
            /* ... */

            return new byte[size];
        }
    }
}