namespace Factory {
    public class IsraeliPizza : Pizza {
        public IsraeliPizza(string[] toppings) : base(toppings) { }

        public override string Type => "Israeli Pizza";
    }
}