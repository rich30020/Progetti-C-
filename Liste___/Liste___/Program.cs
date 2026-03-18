using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<double> numeri = new List<double>();

        // Input di 4 numeri
        for (int i = 0; i < 4; i++)
        {
            Console.Write("Inserisci un numero: ");
            double valore = Convert.ToDouble(Console.ReadLine());
            numeri.Add(valore);
        }

        // Calcolo del massimo
        double massimo = TrovaMassimo(numeri);

        Console.WriteLine("Il valore massimo è: " + massimo);
    }

    // Funzione che trova il massimo nella lista
    static double TrovaMassimo(List<double> lista)
    {
        double max = lista[0];

        foreach (double num in lista)
        {
            if (num > max)
            {
                max = num;
            }
        }

        return max;
    }
}