using System;
using System.Collections.Generic;

Console.WriteLine("Hello, World!");

// creazione 3 istanze Cliente
Cliente c1 = new Cliente(1, "Azienda SRL", "Venezia");
Cliente c2 = new Cliente(2, "Tech SPA", "Milano");
Cliente c3 = new Cliente(3, "Food SRL", "Roma");

// creazione lista
List<Cliente> myListClienti = new List<Cliente>();

// aggiunta alla lista
myListClienti.Add(c1);
myListClienti.Add(c2);
myListClienti.Add(c3);

// stampa lista
foreach (Cliente c in myListClienti)
{
    Console.WriteLine(c);
}

Console.ReadLine();


// classe Cliente
public class Cliente
{
    public int ClienteID { get; set; }
    public string? RagioneSociale { get; set; }
    public string? Provincia { get; set; }

    // costruttore corretto
    public Cliente(int clienteID, string ragioneSociale, string provincia)
    {
        ClienteID = clienteID;
        RagioneSociale = ragioneSociale;
        Provincia = provincia;
    }

    // override ToString per stampa
    public override string ToString()
    {
        return $"ClienteID: {ClienteID}, RagioneSociale: {RagioneSociale}, Provincia: {Provincia}";
    }
}