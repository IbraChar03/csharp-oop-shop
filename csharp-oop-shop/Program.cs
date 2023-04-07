using System;
using System.Globalization;

namespace csharp_oop_shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Prodotto prd1 = new Prodotto("Latte", "descrizione latte", 32, 1.22);
            Console.WriteLine($"Il nome completo del prodotto è {prd1.NomeCompleto()}");
            Console.WriteLine($"Il prezzo base del prodotto  è {prd1.PrezzoBase()}$");
            Console.WriteLine($"l'iva  è {prd1.iva}");
            Console.WriteLine($"Il prezzo compreso di iva del prodotto  è {prd1.PrezzoIva()}$");
      
        }
    }
}