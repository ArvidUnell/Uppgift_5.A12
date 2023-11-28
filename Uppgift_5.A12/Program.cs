using System;
namespace Uppgift_5_A12
{
    class Program
    {
        static void Main(string[] args)
        {
            int antalTärningar = 5;
            int antalSidor = 6;

            Random slump = new Random();

            int[] slagArr = new int[antalTärningar];
            bool[] låst = new bool[antalTärningar];

            while (låst.Contains(false))
            {
                for (int i = 0; i < antalTärningar; i++) //slumpar och skriver ut
                {
                    if (!låst[i])
                    {
                        slagArr[i] = slump.Next(1, antalSidor + 1);
                    }

                    Console.Write($"Tärning {i+1}: {slagArr[i]}");
                    if (låst[i])
                    {
                        Console.Write(" (låst)");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("Vilka tärningar vill du låsa? Skriv in värdena separerade med mellanslag");
                while (true)
                {
                    try
                    {
                        string svar = Console.ReadLine();
                        if (svar == "")
                        {
                            break;
                        }

                        int[] attLåsaArr = Array.ConvertAll(svar.Split(' '), int.Parse);
                        foreach (int attLåsa in attLåsaArr)
                        {
                            låst[attLåsa-1] = true;
                        }
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Det är inte ett giltigt svar. Försök igen");
                    }                  
                }

                Console.WriteLine();
            }
        }
    }
}