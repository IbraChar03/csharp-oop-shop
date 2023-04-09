﻿using System;
using System.Globalization;
using System.Net.Http.Headers;

namespace csharp_oop_shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Prodotto[] prodotti = { new Prodotto("cereali", "descrizione cereali", 2.45, 1.24) };
            for(int i = 0; i < prodotti.Length; i++)
            {
                prodotti[i].setCodice();
                Console.WriteLine(prodotti[i].GetCodice());
                Console.WriteLine($"Il nome completo del prodotto è : {prodotti[i].NomeCompleto()}");
                Console.WriteLine($"Il descrizione del prodotto è : {prodotti[i].descrizione}");
                Console.WriteLine($"Il prezzo base del prodotto  è : {prodotti[i].PrezzoBase()}$");
                Console.WriteLine($"l'iva  è : {prodotti[i].iva}");
                Console.WriteLine($"Il prezzo compreso di iva del prodotto  è : {prodotti[i].PrezzoIva()}$");
            }
           
        }
    }
}