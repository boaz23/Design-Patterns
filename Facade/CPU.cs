using System;

namespace Facade {
    public class CPU {
        public void Freeze() {
            Console.WriteLine("CPU freezing");
        }
        public void Jump(long position) {
            Console.WriteLine($"Jumping to position {position}");
        }
        public void Execute() {
            Console.WriteLine("CPU executing...");
        }
    }
}