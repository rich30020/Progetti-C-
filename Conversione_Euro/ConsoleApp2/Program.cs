using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Input da tastiera");

        // dichiarazione variabili
        string? importoInEuroInput;
        double importoInEuro;

        try
        {
            // input utente
            Console.Write("Inserisci l'importo in euro: ");
            importoInEuroInput = Console.ReadLine();

            // conversione da string a double
            importoInEuro = Convert.ToDouble(importoInEuroInput);

            // tassi di cambio
            double dollariUsa = importoInEuro * 1.09;
            double sterline = importoInEuro * 0.85;
            double yen = importoInEuro * 161.5;

            // output
            Console.WriteLine("Conversione valuta:");
            Console.WriteLine("Dollari USA: " + dollariUsa);
            Console.WriteLine("Sterline: " + sterline);
            Console.WriteLine("Yen: " + yen);
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