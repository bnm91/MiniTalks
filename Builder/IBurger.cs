using System.Collections.Generic;

namespace Learning.Builder
{
    public interface IBurger
    {
        string Avocado { get; set; }
        string Bun { get; set; }
        string Cheese { get; set; }
        List<string> Condiments { get; set; }
        List<string> Extras { get; set; }
        string Protein { get; set; }
        List<string> Vegetables { get; set; }

        string ToString();
    }
}