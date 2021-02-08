using System;
using System.Collections.Generic;

namespace UnitedStatesCryptozoology
{
    public class CryptoZoologyClient : ICryptoZoologyClient
    {

        public CryptoZoologyClient() { }
        public double GetAverageEncounters(string timePeriod = "1y", string stateCode = null, string creature = null)
        {
            #region AverageImplementation
            return 10.1;
            #endregion
        }

        public List<string> GetEncounters(
            string stateCode = null,
            string creature = null,
            DateTime? fromDate = null,
            DateTime? toDate = null)
        {
            #region GetEncountersImplementation
            return new List<string>()
            {
                "Sasquatch 01/05/2020 Skykomish WA",
                "Sasquatch 01/05/2020 Roslyn WA",
                "Sasquatch 01/06/2020 Twin Peaks WA",
                "Sasquatch 01/06/2020 Montlake, Seattle WA",
                "Sasquatch 01/06/2020 Forks WA",
                "Sasquatch 01/07/2020 Jared's Condo, Seattle WA",
                "Sasquatch 01/07/2020 SkyKick WA",
                "Sasquatch 01/08/2020 Gold Bar WA",
                "Sasquatch 01/08/2020 Gold Bar WA",
                "Sasquatch 01/08/2020 Baring WA",
                "Sasquatch 01/08/2020 Spokane WA",
                "Sasquatch 01/09/2020 Index WA",
                "Sasquatch 01/10/2020 Mt Rainier NP WA",
                "Sasquatch 01/15/2020 Stevens Pass WA",
            };
            #endregion
        }

    }
}








/*
 * 
 * 
 *             Secret demo code.  shhhh!
 *             var currentEncountersClient = 
                new USCryptozoologyAdapter(
                    new UnitedStatesCryptozoology.CryptoZoologyClient()
                );
*
*
*/
