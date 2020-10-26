using System;

namespace Dimensione_Immagine_Tepsit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inserisci altezza immagine:");
            int altezza = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("inserisci larghezza immagine:");
            int larghezza = Convert.ToInt32(Console.ReadLine());
            double bianconero = ((altezza * larghezza) * 0.125) * 1024;
            Console.WriteLine($"l'immagine bianco e nero occupa:{bianconero}KB");
            int colori256 = ((altezza * larghezza) * 1) * 1024;
            Console.WriteLine($"l'immagine con 256 colori occupa:{colori256}KB");
            int colori65000 = ((altezza * larghezza) * 2) * 1024;
            Console.WriteLine($"l'immagine con 65000 colori occupa:{colori65000}KB");
            int truecolor = ((altezza * larghezza) * 3) * 1024;
            Console.WriteLine($"l'immagine con truecolor occupa: {truecolor}");
        }
    }
}
