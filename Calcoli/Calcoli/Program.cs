using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello, World!");

        // programma principale 
        double Numero1, Numero2, Risultato, Maggiore;

        // fase di input (finta)
        Numero1 = 4.6;
        Numero2 = 5.7;

        // fase di elaborazione
        Risultato = CalcolaSomma(Numero1, Numero2);
        Maggiore = CalcolaMaggiore(Numero1, Numero2);

        // fase di output
        Console.WriteLine("somma: " + Risultato.ToString());
        Console.WriteLine("maggiore: " + Maggiore.ToString());
    }

    static double CalcolaSomma(double n1, double n2)
    {
        double Somma;
        Somma = n1 + n2;
        return Somma;
    }

    static double CalcolaMaggiore(double n1, double n2)
    {
        if (n1 > n2)
            return n1;
        else
            return n2;
    }
}