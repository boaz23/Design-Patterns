namespace Factory.AbstractFactory.Example1 {
    public class IsraeliPizzaMaker : IPizzaMaker {
        public Pizza MakePizza(string[] toppings) => new IsraeliPizza(toppings);
    }
}