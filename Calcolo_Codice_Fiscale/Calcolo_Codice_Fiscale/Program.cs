using System;

class Program
{
    static void Main()
    {
        string cognome = "MESTRE";
        string nome = "ALESSANDRO";
        string data = "22/10/1974";
        string sesso = "M";
        string comune = "H823";

        string codCognome = CalcolaCognome(cognome);
        string codNome = CalcolaNome(nome);
        string codData = CalcolaData(data, sesso);

        string controllo = "H"; // fisso

        string codiceFiscale = codCognome + codNome + codData + comune + controllo;

        Console.WriteLine(codiceFiscale);
    }

    // --- COGNOME ---
    static string CalcolaCognome(string cognome)
    {
        cognome = cognome.ToUpper();

        string consonanti = "";
        string vocali = "";

        for (int i = 0; i < cognome.Length; i++)
        {
            char c = cognome[i];

            if ("BCDFGHJKLMNPQRSTVWXYZ".Contains(c))
                consonanti += c;
            else if ("AEIOU".Contains(c))
                vocali += c;
        }

        string risultato = consonanti + vocali + "XXX";

        return risultato.Substring(0, 3);
    }

    // --- NOME ---
    static string CalcolaNome(string nome)
    {
        nome = nome.ToUpper();

        string consonanti = "";
        string vocali = "";

        for (int i = 0; i < nome.Length; i++)
        {
            char c = nome[i];

            if ("BCDFGHJKLMNPQRSTVWXYZ".Contains(c))
                consonanti += c;
            else if ("AEIOU".Contains(c))
                vocali += c;
        }

        if (consonanti.Length >= 4)
        {
            return "" + consonanti[0] + consonanti[2] + consonanti[3];
        }

        string risultato = consonanti + vocali + "XXX";
        return risultato.Substring(0, 3);
    }

    // --- DATA ---
    static string CalcolaData(string data, string sesso)
    {
        string[] parti = data.Split('/');

        int giorno = int.Parse(parti[0]);
        int meseNumero = int.Parse(parti[1]);
        string anno = parti[2].Substring(2, 2);

        string mesi = "ABCDEHLMPRST";
        char mese = mesi[meseNumero - 1];

        if (sesso == "F")
            giorno += 40;

        return anno + mese + giorno.ToString("00");
    }
}