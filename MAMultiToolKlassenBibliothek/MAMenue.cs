﻿using System;
using Figgle;



namespace MAMultiToolKlassenBibliothek
{
    public class MAMenue
    {
        public static void MASubMenue()
        {


            string HauptAusw;

            bool Exit = false;
            bool Hmenue;

            do
            {
                (int, int) cPosBM = Console.GetCursorPosition();

                Console.WriteLine();

                //ASCII art Logo wird erzeugt.
                Console.WriteLine
                    (FiggleFonts.Slant.Render("BFTMultiTool"));

                //Konsolentitel wird geändert.
                Console.Title = "BFTMultiTool";

                Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                  "                              >>> Mathematikrechner SubMenü BFTMultiTool <<<\n" +
                                  "------------------------------------------------------------------------------------\n\n");

                Console.WriteLine("Eingabe: exit\t\t->\tbeendet das Programm");
                Console.WriteLine("Eingabe: hauptmenü\t->\tzurück zum Hauptmenü");

                //Beschreibung der Software.
                Console.WriteLine("\n\nWillkommen im Mathematikrechner des BFTMultiTools. Hier können sie zwischen verschiedenen Themenbereichen wählen, welche ihnen beim Lösen von verschiedenen Aufgaben helfen können.\n\n");

                Hmenue = false;

                //Eingabeaufforderung 
                Console.WriteLine("Wählen Sie eine der folgenden Themenbereiche:\n");
                Console.WriteLine("\t1 - Lineare Funktionen");
                Console.WriteLine("\t2 - Quadratische Funktionen");
                Console.WriteLine("\t3 - Flächenberechnung");
                Console.WriteLine("\t4 - Satz des Pythagoras\n");
                Console.Write("Eingabe:");
                HauptAusw = Console.ReadLine();

                switch (HauptAusw)
                {

                    case "1":
                        Console.Clear();
                        Feature17.Feature17Funcion1();

                        break;

                    case "2":
                        Console.Clear();
                        Feature18.Feature18Funcion1();

                        break;

                    case "3":
                        Console.Clear();
                        Feature19.Feature19Funcion1();

                        break;

                    case "4":
                        Console.Clear();
                        Feature16.Feature16Funcion1();
                        break;

                    case "5":
                        Console.Clear();
                        //
                        break;
                    case "hauptmenü":
                        Console.Clear();
                        Hmenue = true;
                        break;
                    case "exit":
                        Exit = true;
                        break;

                    default:

                        Console.WriteLine("Ungültige Eingabe");
                        Console.ReadKey();

                        (int, int) cPosAM = Console.GetCursorPosition();


                        KonsolenExtrasBibliothek.ConsoleExtras.ClearCurrentConsoleLine(cPosBM.Item2, cPosAM.Item2);

                        break;
                }


            } while (!Exit & !Hmenue);

            if (Exit)
                Environment.Exit(0);

        }
    }
}