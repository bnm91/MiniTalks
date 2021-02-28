using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Learning.Builder.WhatNotToDo.Level1
{
    public class Burger : IBurger
    {
        public string Bun { get; set; }
        public string Protein { get; set; }
        public string Cheese { get; set; }
        public string Avocado { get; set; }
        public List<string> Condiments { get; set; }
        public List<string> Vegetables { get; set; }
        public List<string> Extras { get; set; }

        public override string ToString()
        {
            var burgerBuilder = new StringBuilder();
            if (!string.IsNullOrWhiteSpace(Bun))
            {
                burgerBuilder.Append(Bun);
                burgerBuilder.Append(" ");
            }
            if (!string.IsNullOrWhiteSpace(Protein))
            {
                burgerBuilder.Append(Protein);
                burgerBuilder.Append(" ");
            }
            if (!string.IsNullOrWhiteSpace(Cheese))
            {
                burgerBuilder.Append(Cheese);
                burgerBuilder.Append(" ");
            }
            if (!string.IsNullOrWhiteSpace(Avocado))
            {
                burgerBuilder.Append(Avocado);
                burgerBuilder.Append(" ");
            }
            if (Condiments != null)
            {
                foreach (var condiment in Condiments.Where(x => !string.IsNullOrWhiteSpace(x)))
                {
                    burgerBuilder.Append(condiment);
                    burgerBuilder.Append(" ");
                }
            }
            if (Vegetables != null)
            {
                foreach (var vegetable in Vegetables.Where(x => !string.IsNullOrWhiteSpace(x)))
                {
                    burgerBuilder.Append(vegetable);
                    burgerBuilder.Append(" ");
                }
            }
            if (Extras != null)
            {
                foreach (var extra in Extras.Where(x => !string.IsNullOrWhiteSpace(x)))
                {
                    burgerBuilder.Append(extra);
                    burgerBuilder.Append(" ");
                }
            }

            return burgerBuilder.ToString().TrimEnd();
        }
    }
}
