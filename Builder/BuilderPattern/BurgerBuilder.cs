using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Learning.Builder.BuilderPattern
{
    public class BurgerBuilder : IBurgerBuilder
    {
        private Burger _burger;

        public BurgerBuilder() { }

        public Burger BuildBurger()
        {
            return _burger;
        }

        public void Reset()
        {
            _burger = new Burger();
        }

        public BurgerBuilder WithProtein(string protein)
        {
            _burger.Protein = protein;
            return this;
        }
        public BurgerBuilder OnBun(string bun)
        {
            _burger.Bun = bun;
            return this;
        }
        public BurgerBuilder CoveredWithCheese(string cheese)
        {
            _burger.Cheese = cheese;
            return this;
        }
        public BurgerBuilder WithCondiment(string condiment)
        {
            if (_burger.Condiments == null || !_burger.Condiments.Any())
                _burger.Condiments = new List<string>();

            _burger.Condiments.Add(condiment);
            return this;
        }
        public BurgerBuilder WithVegetable(string vegetable)
        {
            if (_burger.Vegetables == null || !_burger.Vegetables.Any())
                _burger.Vegetables = new List<string>();

            _burger.Vegetables.Add(vegetable);
            return this;
        }
        public BurgerBuilder WithExtra(string extra)
        {
            if (_burger.Extras == null || !_burger.Extras.Any())
                _burger.Extras = new List<string>();

            _burger.Extras.Add(extra);
            return this;
        }
        public BurgerBuilder WithAvocado(string avocado)
        {
            _burger.Avocado = avocado;
            return this;
        }
    }
}
