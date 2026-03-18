using System;
using System.Collections.Generic;

namespace ConsoleAppClassi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // creazione oggetto
            Articolo a1 = new Articolo(1, "Mouse", 25.50, 10);

            // aggiunta descrizione
            a1.Descrizione = "Mouse wireless";

            // operazioni
            a1.AggiungiGiacenza(5);

            bool venduto = a1.Vendi(3);

            if (venduto)
            {
                Console.WriteLine("Vendita effettuata!");
            }
            else
            {
                Console.WriteLine("Giacenza insufficiente!");
            }

            // stampa dettagli
            a1.StampaDettagli();

            Console.ReadLine(); // per tenere aperta la console
        }
    }

    // classe Articolo
    public class Articolo
    {
        public int ArticoloID { get; set; }
        public string? Nome { get; set; }
        public string? Descrizione { get; set; }
        public double PrezzoVenditaUnitario { get; set; }
        public int Giacenza { get; set; }
        public double AliquotaIVA { get; set; }

        // costruttore default
        public Articolo()
        {
            AliquotaIVA = 22.0;
        }

        // costruttore con parametri
        public Articolo(int id, string nome, double prezzo, int giacenza)
        {
            ArticoloID = id;
            Nome = nome;
            PrezzoVenditaUnitario = prezzo;
            Giacenza = giacenza;
            AliquotaIVA = 22.0;
        }

        // calcolo prezzo con IVA
        public double CalcolaPrezzoConIVA()
        {
            return PrezzoVenditaUnitario + (PrezzoVenditaUnitario * AliquotaIVA / 100);
        }

        // aggiunge pezzi
        public void AggiungiGiacenza(int quantita)
        {
            Giacenza += quantita;
        }

        // vende pezzi
        public bool Vendi(int quantita)
        {
            if (quantita <= Giacenza)
            {
                Giacenza -= quantita;
                return true;
            }
            return false;
        }

        // stampa info
        public void StampaDettagli()
        {
            Console.WriteLine("ID: " + ArticoloID);
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Descrizione: " + Descrizione);
            Console.WriteLine("Prezzo: " + PrezzoVenditaUnitario);
            Console.WriteLine("Prezzo con IVA: " + CalcolaPrezzoConIVA());
            Console.WriteLine("Giacenza: " + Giacenza);
        }
    }
}