Demo application explaining the Adapter pattern.
UnitedStatesCryptozoology project represents a fictional uneditable 3rd party library.
Set AdapterPatternDemo as startup project and run.

In Program.cs, you can set currentEncountersClient to the following to use the adapter instead of the original client
new USCryptozoologyAdapter(new UnitedStatesCryptozoology.CryptoZoologyClient());