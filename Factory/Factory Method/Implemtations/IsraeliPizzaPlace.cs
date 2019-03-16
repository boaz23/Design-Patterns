namespace Factory.FactoryMethod {
    public class IsraeliPizzaPlace : PizzaPlace {
        protected override Pizza MakePizza(string[] toppings) => new IsraeliPizza(toppings);
    }
}