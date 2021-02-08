using System;
using System.Collections.Generic;

namespace UnitedStatesCryptozoology
{
    public interface ICryptoZoologyClient
    {
        double GetAverageEncounters(string timePeriod = "1y", string stateCode = null, string creature = null);

        /// <summary>
        /// Returns list of encounters.  Encounters follow format Creature Date Location StateCode
        /// </summary>
        List<string> GetEncounters(string stateCode = null, string creature = null, DateTime? fromDate = null, DateTime? toDate = null);
    }
}