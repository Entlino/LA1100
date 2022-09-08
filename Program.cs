using System.Diagnostics;
using System.Globalization;
using System.Security.AccessControl;
byte guesszahl;
byte versuche = 0;
string runde;
start:
byte randomzahlen = Convert.ToByte(new Random().Next(0, 100));
do
{
    Console.Write("Sie können nun eine Zahl zwischen 0 und 100 eingeben:");
     guesszahl = Convert.ToByte(Console.ReadLine());
    Console.WriteLine("--------------------------------------------------------");
    versuche++;
    if (guesszahl < randomzahlen)
    {
        Console.WriteLine("Die gesuchte Zahl ist grösser als die geratene Zahl.");
        Console.WriteLine("");
    }
    else if (guesszahl > randomzahlen)
    {
        Console.WriteLine("Die gesuchte Zahl ist kleiner als die geratete Zahl.");
        Console.WriteLine("");
    }
            
    else if (guesszahl == randomzahlen)       
    {
    Console.WriteLine("Sehr gut!, Sie haben die Gewünschste Zahl erraten!");
    Console.WriteLine("Sie haben " + versuche + " Versuche gebraucht");
    Console.WriteLine("--------------------------------------------------------");
    Console.Write("Möchten Sie nochmal eine runde Spielen? [ja/nein]");
    runde = Convert.ToString(Console.ReadLine());
    }
if (runde.ToLower == "ja")
{
    goto start;
}
else if (runde.ToLower == "nein")
{
    Environment.Exit(0);
}

} while (guesszahl != randomzahlen);
