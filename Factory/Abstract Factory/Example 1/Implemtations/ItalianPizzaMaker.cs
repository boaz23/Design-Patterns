namespace Factory.AbstractFactory.Example1 {
    public class ItalianPizzaMaker : IPizzaMaker {
        public Pizza MakePizza(string[] toppings) => new ItalianPizza(toppings);
    }
}