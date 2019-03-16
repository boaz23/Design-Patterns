namespace Factory.AbstractFactory.Example1 {
    public interface IPizzaMaker {
        Pizza MakePizza(string[] toppings);
    }
}