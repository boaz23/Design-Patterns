namespace Factory.FactoryMethod {
    public class ItalianPizzaPlace : PizzaPlace {
        protected override Pizza MakePizza(string[] toppings) => new ItalianPizza(toppings);
    }
}