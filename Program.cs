using System;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Security.AccessControl;

namespace LA1100_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
        start:
            Console.Title = "Zahlenraten";
            int guesszahl;
            byte versuche = 0;
            string runde;
        
            Level:
            Console.WriteLine("Wollen sie das Spiel auf einfach oder schwer spielen?"); 
            string niveau = Convert.ToString(Console.ReadLine()); 
            if (niveau.ToLower() == "schwer") 
            {
                goto schwer;



            }
            else if (niveau.ToLower() == "einfach")
            {
                goto einfach;



            }
            else
            {
                Console.WriteLine("Ungültige Eingabe");
                
                goto Level;

            }

















          einfach:

            byte randomzahlen = Convert.ToByte(new Random().Next(0, 100));

            try
            { 
                do
                {





                        Console.WriteLine("Sie können nun eine Zahl zwischen 0 und 100 eingeben:");
                        Console.Write("--> ");
                        //Console.WriteLine(randomzahlen);
                    guesszahl = Convert.ToByte(Console.ReadLine());
                    versuche++;
                    if (guesszahl < randomzahlen)
                    {
                        Console.WriteLine("\n[Spiel] Die gesuchte Zahl ist grösser als die geratene Zahl.\n");

                    }
                    else if (guesszahl > randomzahlen)
                    {
                        Console.WriteLine("\nDie gesuchte Zahl ist kleiner als die geratete Zahl.\n");
                    }
                    else if (guesszahl == randomzahlen)
                    {
                        Console.WriteLine("Sehr gut!, Sie haben die Gewünschste Zahl erraten!");
                        Console.WriteLine("Sie haben " + versuche + " Versuche gebraucht.\n");
                    }
                    else if (guesszahl > 100)
                    {
                        Console.WriteLine("Die Zahl ist zu gross");


                    }
                    else if (guesszahl < 0);
                    {
                        Console.WriteLine("Die Zahl ist zu klein");

                    }
                    abfrage:
                        Console.WriteLine("Möchten Sie nochmal eine runde Spielen? [ja/nein]");
                        Console.Write("--> ");


                        runde = Convert.ToString(Console.ReadLine());

                        if (runde.ToLower() == "ja")
                        {
                            Console.Clear();
                            goto start;

                        }
                        else if (runde.ToLower() == "nein")
                        {
                            Environment.Exit(0);
                    
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Ungültige Eingabe!");
                            goto abfrage;
                        }

                    
                } while (guesszahl != randomzahlen);

            }
            catch (Exception e)
            {
                Console.WriteLine("Ungültige Eingabe!");
                goto start;
            }










        schwer:

            int randomzahlenm = Convert.ToInt32(new Random().Next(0, 1000));
            int guesszahl1;
            try
            {
                do
                {





                    Console.WriteLine("Sie können nun eine Zahl zwischen 0 und 1000 eingeben:");
                    Console.Write("--> ");
                    //Console.WriteLine(randomzahlenm);
                    guesszahl1 = Convert.ToInt32(Console.ReadLine());
                    versuche++;
                    if (guesszahl1 < randomzahlenm)
                    {
                        Console.WriteLine("\n[Spiel] Die gesuchte Zahl ist grösser als die geratene Zahl.\n");

                    }
                    else if (guesszahl1 > randomzahlenm)
                    {
                        Console.WriteLine("\nDie gesuchte Zahl ist kleiner als die geratete Zahl.\n");
                    }
                    else if (guesszahl1 == randomzahlenm)
                    {
                        Console.WriteLine("Sehr gut!, Sie haben die Gewünschste Zahl erraten!");
                        Console.WriteLine("Sie haben " + versuche + " Versuche gebraucht.\n");


                    abfrage:
                        Console.WriteLine("Möchten Sie nochmal eine runde Spielen? [ja/nein]");
                        Console.Write("--> ");


                        runde = Convert.ToString(Console.ReadLine());

                        if (runde.ToLower() == "ja")
                        {
                            Console.Clear();
                            goto start;

                        }
                        else if (runde.ToLower() == "nein")
                        {
                            Environment.Exit(0);

                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Ungültige Eingabe!");
                            goto abfrage;
                        }

                    }
                    else if (guesszahl1 > 1000);
                    {
                        Console.WriteLine("Die Zahl ist zu gross");
                    }
                    else if (guesszahl1 < 0) ;
                    {
                        Console.WriteLine("Die Zahl ist zu klein");
                    }
                } while (guesszahl1 != randomzahlenm);

            }
            catch (Exception e)
            {
                Console.WriteLine("Ungültige Eingabe!");
                goto start;
            }




        }
    }
}