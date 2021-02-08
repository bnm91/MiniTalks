using System;

namespace AdapterPatternDemo
{
    public class FriendsOfSasquatchApp
    {
        private readonly IEncountersClient _encountersClient;

        public FriendsOfSasquatchApp(IEncountersClient encountersClient)
        {
            _encountersClient = encountersClient;
        }
        public void Run()
        {
            OutputWelcome();
            OutputSquatchTracks();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("# WA encounters this month: " + _encountersClient.GetEncountersThisMonth());
            Console.WriteLine("Avg # WA encounters per month: " + _encountersClient.GetAverageEncountersPerMonth());
            Console.WriteLine();
            Console.WriteLine("Here's a list of recent sasquatch encounters in Washington");

            var encounters = _encountersClient.GetWashingtonEncounters();

            foreach(var encounter in encounters)
            {
                Console.WriteLine(encounter);
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to finish");
            Console.ReadKey();
        }

        // Fun formatting for the live demo
        private void OutputWelcome()
        {
            Console.WriteLine();
            Console.WriteLine("************************************************");
            Console.WriteLine();
            Console.WriteLine("**  Welcome to the Friends of Sasquatch app  **");
            Console.WriteLine();
            Console.WriteLine("************************************************");
            Console.WriteLine();
        }


        //Fun formatting for the live demo
        private void OutputSquatchTracks()
        {
            Console.WriteLine();
            Console.WriteLine("‎----------Oooo-----"); 
            Console.WriteLine("-----------(----)-----");
            Console.WriteLine("------------)--/------");
            Console.WriteLine("------------(_/---");
            Console.WriteLine("----oooO-------");
            Console.WriteLine("----(---)-------");
            Console.WriteLine("-----\\--(-----");
            Console.WriteLine("------\\_)----");
            Console.WriteLine("-----------Oooo-----");
            Console.WriteLine("-----------(----)-----");
            Console.WriteLine("------------)--/------");
            Console.WriteLine("------------(_/---");
            Console.WriteLine("----oooO-------");
            Console.WriteLine("----(---)-------");
            Console.WriteLine("-----\\--(-----");
            Console.WriteLine("------\\_)----");
            Console.WriteLine();
        }
    }
}
