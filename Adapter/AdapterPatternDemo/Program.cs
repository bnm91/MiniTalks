
namespace AdapterPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //var currentEncountersClient = new EncountersClient();
            var currentEncountersClient = new USCryptozoologyAdapter(new UnitedStatesCryptozoology.CryptoZoologyClient());

            var app = new FriendsOfSasquatchApp(currentEncountersClient);
            app.Run();
        }
    }
}
