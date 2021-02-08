using System.Collections.Generic;

namespace AdapterPatternDemo
{
    public class EncountersClient: IEncountersClient
    {
        public EncountersClient() { }

        public int GetAverageEncountersPerMonth()
        {
            #region averageEncountersImplementation
            return 10;
            #endregion
        }

        public int GetEncountersThisMonth()
        {
            #region monthlyEncountersImplementation
            return 14;
            #endregion
        }

        public IEnumerable<string> GetWashingtonEncounters()
        {
            #region getEncountersImplmentations
            return new List<string>()
            {
                "01/05/2020 Skykomish",
                "01/05/2020 Roslyn",
                "01/06/2020 Twin Peaks",
                "01/06/2020 Montlake, Seattle",
                "01/06/2020 Forks",
                "01/07/2020 Jared's Condo, Seattle",
                "01/07/2020 SkyKick",
                "01/08/2020 Gold Bar",
                "01/08/2020 Gold Bar",
                "01/08/2020 Baring",
                "01/08/2020 Spokane",
                "01/09/2020 Index",
                "01/10/2020 Mt Rainier NP",
                "01/15/2020 Stevens Pass",
            };
            #endregion
        }
    }
}
