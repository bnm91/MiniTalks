namespace Learning.Builder.BuilderPattern.Director
{
    public interface IBurgerDirector
    {
        Burger MakeGlutenFreeBurger();
        Burger MakeNixonsWayBurger();
        Burger MakeStandardBurger();
        Burger MakeVeganBurger();
        Burger MakeVegetarianBurger();
    }
}