using System;

class Program
{
    static void Main()
    {
        double importo;
        double sconto = 0;
        double importoFinale;

        try
        {
            Console.Write("Inserisci l'importo totale dell'acquisto: ");
            importo = Convert.ToDouble(Console.ReadLine());

            if (importo <= 0)
            {
                Console.WriteLine("Errore: l'importo deve essere maggiore di zero.");
                return;
            }

            // calcolo sconto
            if (importo < 50)
            {
                sconto = 0;
            }
            else if (importo < 100)
            {
                sconto = importo * 0.05;
            }
            else if (importo < 200)
            {
                sconto = importo * 0.10;
            }
            else
            {
                sconto = importo * 0.20;
            }

            importoFinale = importo - sconto;

            Console.WriteLine("Importo prima dello sconto: " + importo);
            Console.WriteLine("Sconto applicato: " + sconto);
            Console.WriteLine("Importo finale scontato: " + importoFinale);
        }
        catch (Exception exc)
        {
            Console.WriteLine("Errore di input: " + exc.Message);
        }
        finally
        {
            Console.WriteLine("Fine del programma");
        }

        // ciclo for classico
        for (int contatore = 0; contatore < 10; contatore++)
        {
            Console.WriteLine(contatore);
        }

        // while da 0 a 9
        int contatore3 = 0;
        while (contatore3 < 10)
        {
            Console.WriteLine(contatore3);
            contatore3++;
        }

        // while da 5 a 1
        int contatore4 = 5;
        while (contatore4 >= 1)
        {
            Console.WriteLine(contatore4);
            contatore4--;
        }

        // do...while numero tra 0 e 10
        int numeroInserito;
        string? numeroInseritoString;

        do
        {
            Console.Write("Inserisci un numero compreso fra 0 e 10: ");
            numeroInseritoString = Console.ReadLine();
            numeroInserito = Convert.ToInt32(numeroInseritoString);

        } while (numeroInserito < 0 || numeroInserito > 10);
        
        // quadrato di asterischi
        int latoQuadrato;
        string? latoQuadratoString;

        do
        {
            Console.Write("Inserisci la lunghezza del lato del quadrato (1-10): ");
            latoQuadratoString = Console.ReadLine();
            latoQuadrato = Convert.ToInt32(latoQuadratoString);

            if (latoQuadrato < 1 || latoQuadrato > 10)
            {
                Console.WriteLine("Errore: inserisci un numero valido tra 1 e 10.");
            }

        } while (latoQuadrato < 1 || latoQuadrato > 10);

        // stampa quadrato
        for (int i = 0; i < latoQuadrato; i++)
        {
            for (int j = 0; j < latoQuadrato; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }

        Console.ReadLine();
    }
}