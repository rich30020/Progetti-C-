Console.WriteLine("Input da tastiera");
// input da tastiera
// chiede all'utente base e altezza 
// e calcola area e perimetro del rettangolo

// dichiarazione variabili 
// input dei dati è sempre String
String? BaseString,AltezzaString, Messaggio;
// variabili numeriche 
Double Base, Altezza, Area, Perimetro;
// da questo punto in poi il programma può
// impiantarsi per vari motivi 
// (tipico: conversioni di tipo errate)
try
{
    // codice a rischio
    // fase di input: chiedo all'utente i dati:
    Console.Write("Inserisci la base: ");
    // leggo il valore e lo assegno a BaseString
    BaseString = Console.ReadLine();
    // converto da String a Double
    Base = Convert.ToDouble(BaseString);
    // rifaccio tutto per l'altezza
    Console.Write("Inserisci l'altezza: ");
    AltezzaString = Console.ReadLine();
    Altezza= Convert.ToDouble(AltezzaString);
    // calcoli 
    Area = Base * Altezza;
    Perimetro = (Base * Altezza) * 2;
    // fase di output: costruisco il messaggio per l'utente
    Messaggio = "Area: " + Area + " Perimetro: " + Perimetro;
    Console.Write(Messaggio);
    Console.ReadLine();


}
catch (Exception exc)
{
    // eccezzione non gestita o non prevista
    Console.WriteLine("Eccezzione: " + exc.ToString());
}
finally
{
    // codice che viene eseguito sempre
    // anche se c'è un'eccezzione non gestita
    Console.WriteLine("Fine del programma");
}