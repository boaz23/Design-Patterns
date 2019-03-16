using System;

namespace Adapter.Example1 {
    // Adaptee
    public interface IDviSocket {
        byte[,][] GetScreenBuffer();
    }

    public class DviSocket : IDviSocket {
        public byte[,][] GetScreenBuffer() {
            // A screen of 1920x1080 while each pixel is represented by 4 bytes to form an ARGB value of color
            var buffer = new byte[1920, 1080][]; // an array of rank 2 of byte arrays that represents a 4 byte pixel each

            int len1 = buffer.GetLength(0); // 1st rank length: 1920
            int len2 = buffer.GetLength(1); // 2nd rank length: 1080
            for (int i = 0; i < len1; i++) {
                for (int j = 0; j < len2; j++) {
                    var random = new Random();
                    buffer[i, j] = new byte[4] {
                        (byte)random.Next(0, 255),
                        (byte)random.Next(0, 255),
                        (byte)random.Next(0, 255),
                        (byte)random.Next(0, 255)
                    };
                }
            }

            return buffer;
        }
    }
}