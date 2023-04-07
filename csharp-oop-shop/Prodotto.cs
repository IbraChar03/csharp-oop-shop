using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop
{
    internal class Prodotto
    {
        private int codice;
        //private string nome;
        //private string descrizione;
        //private int prezzo;
        public string GetCodice()
        {
            Random rnd = new Random(); codice = rnd.Next(1, 99999999);
            int left = (int) Math.Floor(Math.Log10(codice) + 1);
            if (left < 8)
            {
               string codiceNuovo =  codice.ToString().PadLeft(5);
                string parola = codice.ToString();
                Console.WriteLine(parola.PadLeft(8,'0'));
                Console.WriteLine(codice.ToString());
                return codiceNuovo;
              
            }
            return  codice.ToString();
        }
        public double prezzo { set; get; }
        public double iva { set; get; }
       
        public string descrizione { set; get; }
        public string nome { set; get; }
        public double PrezzoBase()
        {
            return prezzo;
        }
        public double PrezzoIva()
        {
            return prezzo * iva;
        }
        public string NomeCompleto()
        {
            return nome + GetCodice();
        }
        public Prodotto(string nome, string descrizione, double prezzo, double iva)
        {
            this.nome = nome;
            this.descrizione = descrizione;
            this.prezzo = prezzo;
            this.iva = iva;
        }



    }
}
