using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Input da tastiera");

        // dichiarazione variabili
        string? NomeStudente;
        double primoVoto;
        double secondoVoto;
        double terzoVoto;

        try
        {
            // input nome studente
            Console.Write("Inserisci il nome dello studente: ");
            NomeStudente = Console.ReadLine();

            // input voti
            Console.Write("Inserisci il primo voto: ");
            primoVoto = Convert.ToDouble(Console.ReadLine());

            Console.Write("Inserisci il secondo voto: ");
            secondoVoto = Convert.ToDouble(Console.ReadLine());

            Console.Write("Inserisci il terzo voto: ");
            terzoVoto = Convert.ToDouble(Console.ReadLine());

            // calcolo media
            double media = (primoVoto + secondoVoto + terzoVoto) / 3;

            // output
            Console.WriteLine("Studente: " + NomeStudente);
            Console.WriteLine("Media dello studente: " + media);
        }
        catch (Exception exc)
        {
            // gestione errore
            Console.WriteLine("Eccezione: " + exc.Message);
        }
        finally
        {
            // eseguito sempre
            Console.WriteLine("Fine del programma");
        }

        Console.ReadLine();
    }
}