using System;

namespace Facade {
    public class Memory {
        public void Load(long position, byte[] data) {
            Console.WriteLine($"Loading data of length {data.Length} to position {position}");
        }
    }
}