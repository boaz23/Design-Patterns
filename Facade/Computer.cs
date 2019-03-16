namespace Facade {
    // Facade
    public class Computer {
        private const int BOOT_ADDRESS = 0x10;
        private const int BOOT_SECTOR = 0x0;
        private const int SECTOR_SIZE = 0x200;

        private CPU Processor { get; }
        private Memory Ram { get; }
        private HardDrive HardDrive { get; }

        public Computer() {
            this.Processor = new CPU();
            this.Ram = new Memory();
            this.HardDrive = new HardDrive();
        }

        public void Start() {
            this.Processor.Freeze();
            this.Ram.Load(BOOT_ADDRESS, this.HardDrive.Read(BOOT_SECTOR, SECTOR_SIZE));
            this.Processor.Jump(BOOT_ADDRESS);
            this.Processor.Execute();
        }
    }
}