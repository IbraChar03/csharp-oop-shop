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
        private string codice;
       
        public string GetCodice()
        {
           
            return codice.ToString();
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
            double prezzoiva = prezzo * iva;
                
            return  Math.Round(prezzoiva, 2);
        }
        public string NomeCompleto()

        {

            return  GetCodice() + nome;
        }
        public void setCodice()
        {
            //int codice = Int32.Parse(this.codice);
            int left = (int)Math.Floor(Math.Log10(Int32.Parse(this.codice)) + 1);
            if (left < 8)
            {
                string codiceNuovo = this.codice.ToString().PadLeft(8, '0');
                 this.codice = codiceNuovo;

            }
         
        }
        public Prodotto(string nome, string descrizione, double prezzo, double iva)
        {
            this.nome = nome;
            this.descrizione = descrizione;
            this.prezzo = prezzo;
            this.iva = iva;
            Random rnd = new Random(); int codiceRandom = rnd.Next(1, 99999999);
            this.codice = codiceRandom.ToString();

        }

    }
}
