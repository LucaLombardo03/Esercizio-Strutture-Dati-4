using System;
using System.IO;

namespace Esercizio_Strutture_Dati_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = "test.txt";
            Console.WriteLine("Inserisci il valore da cercare: ");
            string valore = Console.ReadLine();
            if (File.Exists(file))
            {
                try
                {
                    using (StreamReader sr = new StreamReader(file))
                    {
                        string line; 
                        while ((line = sr.ReadLine()) != null)
                        {
                            if (line.Contains(valore))
                            {
                                Console.WriteLine($"Il file contiene il valore {valore}");
                            }
                        }
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.ReadLine();
            }
        }
    }
}
