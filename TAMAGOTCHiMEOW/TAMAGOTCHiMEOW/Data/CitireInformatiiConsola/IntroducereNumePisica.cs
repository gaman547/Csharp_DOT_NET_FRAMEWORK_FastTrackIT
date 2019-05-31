﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAMAGOTCHiMEOW
{
    public class IntroducereNumePisica
    {
        public static string nume = string.Empty;
        
        public static string Nume()
        {
            nume = Console.ReadLine().TrimStart(' ').TrimEnd(' ');

            if (string.IsNullOrEmpty(nume) || string.IsNullOrWhiteSpace(nume))
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Va rog sa introduceti un nume!");
                Console.ResetColor();
            }

            else if ((!string.IsNullOrEmpty(nume) || string.IsNullOrWhiteSpace(nume)) && nume.Length >= 3)
            {
                Console.WriteLine();
                Console.WriteLine($"A-ti introdus numele: {nume}, continuati? (DA/NU)");
                string raspuns1 = Console.ReadLine().TrimStart(' ').TrimEnd(' ');
                switch (raspuns1.ToLower())
                {                  
                        case "da":
                          ButonCreare.CreareAnimal();
                         
                        break;

                        case "nu":
                          ButonContinuare.MeniuAlegeNume = false;
                        break;

                        default:
                          Console.WriteLine();
                          Console.ForegroundColor = ConsoleColor.DarkRed;
                          Console.WriteLine("Raspuns gresit! Doriti sa continuam cu acest nume sau o schimbam? (DA/NU)");
                          Console.ResetColor();

                                  string raspuns2 = Console.ReadLine().TrimStart(' ').TrimEnd(' ');

                                  const string DA = "da";
                                  const string NU = "nu";

                                  switch(raspuns2.ToLower())
                                  {
                                         case DA:
                                           ButonCreare.CreareAnimal();
                                           
                                         break;

                                         case NU:
                                            Console.WriteLine();
                                            Console.WriteLine("Va rog sa introduceti nume: ");
                                            nume = Console.ReadLine().TrimStart(' ').TrimEnd(' ');
                                            ButonCreare.CreareAnimal();
                                         break;

                                         default:
                                            Console.WriteLine();
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("Am detectat 2 raspunsuri gresite concomitente!");
                                            Console.ResetColor();
                                            ButonContinuare.MeniuAlegeNume = false;
                                          break;
                                  }
                      break;
                }
            }              
          return nume;
        }
    }
}