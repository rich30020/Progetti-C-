using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Input da tastiera");

        // dichiarazione variabili
        string? NomeProdotto;
        double quantita;
        double prezzoUnitario;
        double PercentualeSconto;
        double AliquotaIVA;

        double imponibilePrimaSconto;
        double sconto;
        double imponibileScontato;
        double iva;
        double totaleDaPagare;

        try
        {
            // input nome prodotto
            Console.Write("Inserisci il nome del prodotto: ");
            NomeProdotto = Console.ReadLine();

            // input quantità
            Console.Write("Inserisci la quantità acquistata: ");
            quantita = Convert.ToDouble(Console.ReadLine());

            // input prezzo unitario
            Console.Write("Inserisci il prezzo unitario: ");
            prezzoUnitario = Convert.ToDouble(Console.ReadLine());

            // input percentuale sconto
            Console.Write("Inserisci la percentuale di sconto: ");
            PercentualeSconto = Convert.ToDouble(Console.ReadLine());

            // input aliquota IVA
            Console.Write("Inserisci l'aliquota IVA: ");
            AliquotaIVA = Convert.ToDouble(Console.ReadLine());

            // ******** FASE DI ELABORAZIONE ********

            imponibilePrimaSconto = quantita * prezzoUnitario;

            sconto = imponibilePrimaSconto * PercentualeSconto / 100;

            imponibileScontato = imponibilePrimaSconto - sconto;

            iva = imponibileScontato * AliquotaIVA / 100;

            totaleDaPagare = imponibileScontato + iva;

            // ******** OUTPUT ********

            Console.WriteLine("********** fase di elaborazione **************");
            Console.WriteLine("Prodotto: " + NomeProdotto);
            Console.WriteLine("Imponibile prima dello sconto: " + imponibilePrimaSconto);
            Console.WriteLine("Sconto: " + sconto);
            Console.WriteLine("Imponibile scontato: " + imponibileScontato);
            Console.WriteLine("IVA " + AliquotaIVA + "% di " + imponibileScontato + ": " + iva);
            Console.WriteLine("Totale da pagare iva inclusa: " + totaleDaPagare);
        }
        catch (Exception exc)
        {
            // gestione errore
            Console.WriteLine("Eccezione: " + exc.Message);
        }
        finally
        {
            Console.WriteLine("Fine del programma");
        }

        Console.ReadLine();
    }
}