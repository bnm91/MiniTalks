using System;
using System.Collections.Generic;
using System.Linq;
using UnitedStatesCryptozoology;

namespace AdapterPatternDemo
{
    public class USCryptozoologyAdapter : IEncountersClient
    {
        private readonly ICryptoZoologyClient _cryptoZoologyClient;

        public USCryptozoologyAdapter(ICryptoZoologyClient cryptoZoologyClient)
        {
            _cryptoZoologyClient = cryptoZoologyClient;
        }

        public int GetAverageEncountersPerMonth()
        {
             return Convert.ToInt32(_cryptoZoologyClient.GetAverageEncounters("1m", "WA", "Sasquatch"));
        }

        public int GetEncountersThisMonth()
        {
            return _cryptoZoologyClient.GetEncounters(stateCode: "WA", creature: "Sasquatch", fromDate: DateTime.Now.AddMonths(-1)).Count;
        }

        public IEnumerable<string> GetWashingtonEncounters()
        {
            return _cryptoZoologyClient
                .GetEncounters(stateCode: "WA", creature: "Sasquatch", fromDate: DateTime.Now.AddMonths(-1))
                .Select(x => x.Substring(0, x.Length - 3).Substring(11, x.Length - 14));
        }
    }
}
