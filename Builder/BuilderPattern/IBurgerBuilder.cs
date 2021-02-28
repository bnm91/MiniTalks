namespace Learning.Builder.BuilderPattern
{
    public interface IBurgerBuilder
    {
        Burger BuildBurger();
        void Reset();
        BurgerBuilder CoveredWithCheese(string cheese);
        BurgerBuilder OnBun(string bun);
        BurgerBuilder WithAvocado(string avocado);
        BurgerBuilder WithCondiment(string condiment);
        BurgerBuilder WithExtra(string extra);
        BurgerBuilder WithProtein(string protein);
        BurgerBuilder WithVegetable(string vegetable);
    }
}