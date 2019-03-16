namespace Factory {
    public abstract class Pizza {
        public Pizza(string[] toppings) {
            this.Toppings = toppings;
        }

        public string[] Toppings { get; }
        public abstract string Type { get; }
    }
}