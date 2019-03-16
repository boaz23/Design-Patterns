namespace Factory {
    public class ItalianPizza : Pizza {
        public ItalianPizza(string[] toppings) : base(toppings) { }

        public override string Type => "Italian Pizza";
    }
}