using System.Collections.Generic;

namespace AdapterPatternDemo
{
    public interface IEncountersClient
    {
        int GetEncountersThisMonth();
        int GetAverageEncountersPerMonth();
        IEnumerable<string> GetWashingtonEncounters();
    }
}
