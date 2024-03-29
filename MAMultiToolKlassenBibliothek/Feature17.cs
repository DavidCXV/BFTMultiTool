﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figgle;

namespace MAMultiToolKlassenBibliothek
{
    class Feature17
    {
        public static void Feature17Funcion1()
        {
            Console.WriteLine("Feature17 SubSubMenue");


            string HauptAusw;

            bool Exit = false;
            bool Submenü;

            do
            {
                (int, int) cPosBM = Console.GetCursorPosition();

                Console.WriteLine();


                Console.WriteLine
                    (FiggleFonts.Slant.Render("BFTMultiTool"));

                Console.Title = "BFTMultiTool";

                Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                  "                              >>> Mathematikrechner: Lineare Funktionen  <<<\n" +
                                  "------------------------------------------------------------------------------------\n\n");

                Console.WriteLine("Eingabe: exit\t\t->\tbeendet das Programm");
                Console.WriteLine("Eingabe: submenü\t->\tzurück zum Hauptmenü");


                Console.WriteLine("\n\nHier können Sie zwischen Nullstellen und einer Wertetabelle auswählen, zu Linearen Funktionen!\n\n");

                Submenü = false;


                Console.WriteLine("Wählen Sie eine der folgenden Themenbereiche:\n");
                Console.WriteLine("\t1 - Nullstellen");
                Console.WriteLine("\t2 - Wertetabelle");
                Console.Write("Eingabe:");
                HauptAusw = Console.ReadLine();

                switch (HauptAusw)
                {

                    case "1":
                        Console.Clear();
                        Nullstellen();

                        break;



                        break;

                    case "submenü":
                        Console.Clear();
                        Submenü = true;
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


            } while (!Exit & !Submenü);

            if (Exit)
                Environment.Exit(0);


            static void Nullstellen()
            {
                int m;
                int b;
                float x;
                int num1 = 0; int num2 = 0;



                Console.WriteLine("Geben sie eine Steigung m ein:");         // Fordert den Nutzer auf eine Steigung einzugeben
                m = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Geben sie den y-Achsenschnittpunkt b ein:");     // Fordert den Nutzer auf ein Y-achsenabschnitt einzugeben   
                b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("=> f(x) = " + m + "*" + "x + " + b);              // Allgemine Funktionsgleichung


                // Nullstellen Berechnen
                /*
                 * 
                 * y = mx + b
                 * => 0 = mx+b   |-b
                 * => -b =mx
                 * => x = -b/m
                 * 
                 */

                x = -1.0f * b / m;
                Console.WriteLine("Die Nullstelle ist: " + x);              //Ausgabe der Nullstellen
                Console.ReadLine();


                double sweite = 1;
                double von = -3;
                double bis = 3;




                Console.WriteLine("|{0,10}|{1,10}|", "x", "y");
                Console.WriteLine("--------------------|");


                for (double l_x = von; l_x <= bis; l_x += sweite)
                {
                    Console.WriteLine("|{0,10:F2}|{1,10:F2}|", l_x, (l_x * m + b));
                }

                //Console.WriteLine($"| {x} * {-3} = " + (x * -3))

                //Console.WriteLine($"Für -3 ist Das Ergebnis: {x} * {-3} = " + (x * -3));   // Ausgabe der Wertetabelle
                //Console.ReadLine();

                //Console.WriteLine($"Für -2 ist Das Ergebnis: {x} * {-2} = " + (x * -2));
                //Console.ReadLine();

                //Console.WriteLine($"Für -1 ist Das Ergebnis: {x} * {-1} = " + (x * -1));
                //Console.ReadLine();

                //Console.WriteLine($"Für 0 ist Das Ergebnis: {x} * {0} = " + (x * 0));
                //Console.ReadLine();

                //Console.WriteLine($"Für 1 ist Das Ergebnis: {x} * {1} = " + (x * 1));
                //Console.ReadLine();

                //Console.WriteLine($"Für 2 ist Das Ergebnis: {x} * {2} = " + (x * 2));
                //Console.ReadLine();

                //Console.WriteLine($"Für 3 ist Das Ergebnis: {x} * {3} = " + (x * 3));
                //Console.ReadLine();

                //Console.WriteLine("Mit diesen Zahlen können sie einen Graphen Zeichnen. Viel Erfolg!");
                Console.ReadLine();



            }

        }




    }

}









