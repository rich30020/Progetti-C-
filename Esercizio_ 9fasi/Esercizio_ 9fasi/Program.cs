using System;
using System.Collections.Generic;

List<Articolo> lista = new List<Articolo>();
bool continua = true;

while (continua)
{
    Console.WriteLine("\n1 Inserisci");
    Console.WriteLine("2 Stampa lista");
    Console.WriteLine("3 Cerca per ID");
    Console.WriteLine("4 Elimina");
    Console.WriteLine("5 Aggiorna prezzo");
    Console.WriteLine("6 Cerca testo");
    Console.WriteLine("7 Valore magazzino");
    Console.WriteLine("8 Filtra prezzo");
    Console.WriteLine("9 Esci");

    int scelta = int.Parse(Console.ReadLine());

    // 1 INSERISCI
    if (scelta == 1)
    {
        Console.Write("ID: ");
        int id = int.Parse(Console.ReadLine());

        bool esiste = false;

        foreach (Articolo a in lista)
        {
            if (a.ArticoloID == id)
            {
                esiste = true;
            }
        }

        if (esiste)
        {
            Console.WriteLine("ID già esistente!");
        }
        else
        {
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Descrizione: ");
            string desc = Console.ReadLine();

            Console.Write("Prezzo: ");
            double prezzo = double.Parse(Console.ReadLine());

            Console.Write("Giacenza: ");
            int giacenza = int.Parse(Console.ReadLine());

            lista.Add(new Articolo(id, nome, desc, prezzo, giacenza));
        }
    }

    // 2 STAMPA
    else if (scelta == 2)
    {
        foreach (Articolo a in lista)
        {
            Console.WriteLine(a);
        }
    }

    // 3 CERCA
    else if (scelta == 3)
    {
        Console.Write("ID: ");
        int id = int.Parse(Console.ReadLine());

        bool trovato = false;

        foreach (Articolo a in lista)
        {
            if (a.ArticoloID == id)
            {
                Console.WriteLine(a);
                trovato = true;
            }
        }

        if (!trovato)
            Console.WriteLine("Non trovato");
    }

    // 4 ELIMINA
    else if (scelta == 4)
    {
        Console.Write("ID: ");
        int id = int.Parse(Console.ReadLine());

        for (int i = 0; i < lista.Count; i++)
        {
            if (lista[i].ArticoloID == id)
            {
                lista.RemoveAt(i);
                Console.WriteLine("Eliminato");
                break;
            }
        }
    }

    // 5 AGGIORNA PREZZO
    else if (scelta == 5)
    {
        Console.Write("ID: ");
        int id = int.Parse(Console.ReadLine());

        foreach (Articolo a in lista)
        {
            if (a.ArticoloID == id)
            {
                Console.Write("Percentuale (es 10 o -10): ");
                double perc = double.Parse(Console.ReadLine());

                a.PrezzoVenditaUnitario = a.PrezzoVenditaUnitario + (a.PrezzoVenditaUnitario * perc / 100);
                Console.WriteLine("Aggiornato");
            }
        }
    }

    // 6 CERCA TESTO
    else if (scelta == 6)
    {
        Console.Write("Testo: ");
        string testo = Console.ReadLine().ToLower();

        foreach (Articolo a in lista)
        {
            if ((a.Nome.ToLower().Contains(testo)) || (a.Descrizione.ToLower().Contains(testo)))
            {
                Console.WriteLine(a);
            }
        }
    }

    // 7 VALORE MAGAZZINO
    else if (scelta == 7)
    {
        double totaleNoIVA = 0;
        double totaleIVA = 0;

        foreach (Articolo a in lista)
        {
            totaleNoIVA += a.PrezzoVenditaUnitario * a.Giacenza;
            totaleIVA += a.PrezzoConIVA() * a.Giacenza;
        }

        Console.WriteLine("Totale senza IVA: " + totaleNoIVA);
        Console.WriteLine("Totale con IVA: " + totaleIVA);
    }

    // 8 FILTRO PREZZO
    else if (scelta == 8)
    {
        Console.Write("Min: ");
        double min = double.Parse(Console.ReadLine());

        Console.Write("Max: ");
        double max = double.Parse(Console.ReadLine());

        foreach (Articolo a in lista)
        {
            if (a.PrezzoVenditaUnitario >= min && a.PrezzoVenditaUnitario <= max)
            {
                Console.WriteLine(a);
            }
        }
    }

    // 9 ESCI
    else if (scelta == 9)
    {
        continua = false;
    }
}


// CLASSE
public class Articolo
{
    public int ArticoloID;
    public string Nome;
    public string Descrizione;
    public double PrezzoVenditaUnitario;
    public int Giacenza;
    public double AliquotaIVA = 22;

    public Articolo(int id, string nome, string desc, double prezzo, int giacenza)
    {
        ArticoloID = id;
        Nome = nome;
        Descrizione = desc;
        PrezzoVenditaUnitario = prezzo;
        Giacenza = giacenza;
    }

    public double PrezzoConIVA()
    {
        return PrezzoVenditaUnitario * (1 + AliquotaIVA / 100);
    }

    public override string ToString()
    {
        return "ID:" + ArticoloID + " Nome:" + Nome + " Prezzo:" + PrezzoVenditaUnitario + " Giacenza:" + Giacenza;
    }
}