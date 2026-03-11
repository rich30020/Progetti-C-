Console.WriteLine("Hello, World!");
/*
// Le liste in c#
// finora abbiamo visto variabili che assumono solo un valore 
// le liste sono variabili che assumono più valori, sono collezioni di dati
// dello stesso tipo 
// ex array 

// creiamo una lista di interi 
List<Int32> myList;
// la variabile si chiama myList, è una lista di interi, per ora vale null
// la variabile VA INSTANZIATA, cioè deve essere creata con new

myList = new List<Int32>();
// aggiungiamo dati alla lista
myList.Add(44); // indice 0
myList.Add(12); // indice 1
myList.Add(33); // indice 2
myList.Add(167); // indice 3
myList.Add(9); // indice 4

Console.WriteLine("Numero di Elementi myList: " + myList.Count);

// come stampiamo gli elementi della lista
// metodo da anziani col ciclo for classico 
Int32 indice;
for (indice = 0; indice < myList.Count; indice++)
{
    Console.WriteLine(myList[indice].ToString());
}

// ciclo foreach più modernoù
foreach (Int32 numero in myList)
{
    Console.WriteLine(numero.ToString());
}

// come modifico l'elemento di indice 1?
myList[1] = 777; 

// come rimuovo l'elemento nella posizione con indice 2?
myList.RemoveAt(2);

// funzioni già pronte 
Console.WriteLine(myList.Min());






//ESERCIZIO: chiedere all'utente di inserire 5 temperature, salvarle in una lista e poi classificarle

Console.WriteLine("Inserisci 5 temperature");

// creiamo la lista
List<double> myListTemperature = new List<double>();

int i = 0;

while (i < 5)
{
    double temperatura;

    do
    {
        Console.Write("Inserisci temperatura: ");
        temperatura = Convert.ToDouble(Console.ReadLine());

        if (temperatura <= -273.15)
        {
            Console.WriteLine("Errore: la temperatura deve essere maggiore di -273.15");
        }

    } while (temperatura <= -273.15);

    myListTemperature.Add(temperatura);

    i++;
}

Console.WriteLine("Classificazione temperature:");

// scorriamo la lista
foreach (double temperatura in myListTemperature)
{
    if (temperatura < 15)
    {
        Console.WriteLine(temperatura + " -> Freddo");
    }
    else if (temperatura >= 15 && temperatura <= 25)
    {
        Console.WriteLine(temperatura + " -> Temperato");
    }
    else
    {
        Console.WriteLine(temperatura + " -> Caldo");
    }
}


Console.WriteLine("Inserisci 5 numeri compresi tra 0 e 100");

List<double> myListNumeri = new List<double>();

int i = 0;

while (i < 5)
{
    double numero;

    do
    {
        Console.Write("Inserisci numero: ");
        numero = Convert.ToDouble(Console.ReadLine());

        if (numero < 0 || numero > 100)
        {
            Console.WriteLine("Errore: inserire un numero tra 0 e 100");
        }

    } while (numero < 0 || numero > 100);

    myListNumeri.Add(numero);

    i++;
}


// calcolo media, min e max senza metodi pronti
double somma = 0;
double min = myListNumeri[0];
double max = myListNumeri[0];

foreach (double numero in myListNumeri)
{
    somma = somma + numero;

    if (numero < min)
    {
        min = numero;
    }

    if (numero > max)
    {
        max = numero;
    }
}

double media = somma / myListNumeri.Count;


// stampa risultati
Console.WriteLine("Media: " + media);
Console.WriteLine("Min: " + min);
Console.WriteLine("Max: " + max);


// numeri maggiori della media
Console.WriteLine("Numeri maggiori della media:");

foreach (double numero in myListNumeri)
{
    if (numero > media)
    {
        Console.WriteLine(numero);
    }
}


// gestiamo menu testuali con do while e switch 
String? Scelta;
do
{
    Console.WriteLine("Scegli un' opzione: ");
    Console.WriteLine("1: Opzione 1");
    Console.WriteLine("2: Opzione 2");
    Console.WriteLine("3: Esci");
    Console.Write("Inserisci il numero per l'opzione scelta: ");
    Scelta = Console.ReadLine();
    // vado a capo
    Console.WriteLine();
    switch (Scelta)
    {
        case "1":
            Console.WriteLine("Hai scelto l'opzione 1");
            break;
        case "2":
            Console.WriteLine("Hai scelto l'opzione 2");
            break;
        case "3":
            Console.WriteLine("Hai scelto l'opzione 3");
            break;
        default:
            Console.WriteLine("Scelta non valida, riprova");
            break;
    }
}
while (Scelta != "3");
Console.WriteLine("fine del programma");
*/

/*
Scegli una opzione:
1 Aggiungi un numero alla lista
2 Stampa tutta la lista
3 Elimina un elemento dalla lista in base alla posizione (indice)
4 Aggiorna un elemento della lista in base alla posizione (indice)
5 Pulisci tutta la lista
6 Calcola e stampa la media
7 Calcola e stampa il massimo
8 Calcola e stampa il minimo
9 Conta quanti elementi sono presenti nella lista
10 Stampa solo i numeri maggiori di un valore scelto dall’utente
11 Cerca un numero nella lista e stampa in quale posizione si trova
12 Esci

Regole aggiuntive:

Prima di eseguire operazioni come media, massimo, minimo, stampa, eliminazione o aggiornamento, controllare se la lista è vuota.
Quando si richiede un indice, verificare che sia valido.
Dopo ogni operazione, mostrare un messaggio di conferma o di errore.
Nella stampa della lista, visualizzare anche l’indice di ogni elemento.
*/

List<double> listaNumeri = new List<double>();

int scelta = 0;

do
{
    Console.WriteLine("\nScegli una opzione:");
    Console.WriteLine("1 Aggiungi un numero alla lista");
    Console.WriteLine("2 Stampa tutta la lista");
    Console.WriteLine("3 Elimina un elemento dalla lista in base alla posizione (indice)");
    Console.WriteLine("4 Aggiorna un elemento della lista in base alla posizione (indice)");
    Console.WriteLine("5 Pulisci tutta la lista");
    Console.WriteLine("6 Calcola e stampa la media");
    Console.WriteLine("7 Calcola e stampa il massimo");
    Console.WriteLine("8 Calcola e stampa il minimo");
    Console.WriteLine("9 Conta quanti elementi sono presenti nella lista");
    Console.WriteLine("10 Stampa solo i numeri maggiori di un valore scelto dall’utente");
    Console.WriteLine("11 Cerca un numero nella lista e stampa in quale posizione si trova");
    Console.WriteLine("12 Esci");

    scelta = Convert.ToInt32(Console.ReadLine());

    switch (scelta)
    {
        case 1:
            Console.Write("Inserisci numero: ");
            double numero = Convert.ToDouble(Console.ReadLine());
            listaNumeri.Add(numero);
            Console.WriteLine("Numero aggiunto.");
            break;

        case 2:
            if (listaNumeri.Count == 0)
            {
                Console.WriteLine("La lista è vuota.");
            }
            else
            {
                for (int i = 0; i < listaNumeri.Count; i++)
                {
                    Console.WriteLine("Indice " + i + ": " + listaNumeri[i]);
                }
            }
            break;

        case 3:
            if (listaNumeri.Count == 0)
            {
                Console.WriteLine("La lista è vuota.");
            }
            else
            {
                Console.Write("Inserisci indice da eliminare: ");
                int indice = Convert.ToInt32(Console.ReadLine());

                if (indice >= 0 && indice < listaNumeri.Count)
                {
                    listaNumeri.RemoveAt(indice);
                    Console.WriteLine("Elemento eliminato.");
                }
                else
                {
                    Console.WriteLine("Indice non valido.");
                }
            }
            break;

        case 4:
            if (listaNumeri.Count == 0)
            {
                Console.WriteLine("La lista è vuota.");
            }
            else
            {
                Console.Write("Inserisci indice da aggiornare: ");
                int indice = Convert.ToInt32(Console.ReadLine());

                if (indice >= 0 && indice < listaNumeri.Count)
                {
                    Console.Write("Inserisci nuovo valore: ");
                    double nuovo = Convert.ToDouble(Console.ReadLine());
                    listaNumeri[indice] = nuovo;
                    Console.WriteLine("Elemento aggiornato.");
                }
                else
                {
                    Console.WriteLine("Indice non valido.");
                }
            }
            break;

        case 5:
            listaNumeri.Clear();
            Console.WriteLine("Lista svuotata.");
            break;

        case 6:
            if (listaNumeri.Count == 0)
            {
                Console.WriteLine("Lista vuota.");
            }
            else
            {
                double somma = 0;
                foreach (double n in listaNumeri)
                {
                    somma += n;
                }

                double media = somma / listaNumeri.Count;
                Console.WriteLine("Media: " + media);
            }
            break;

        case 7:
            if (listaNumeri.Count == 0)
            {
                Console.WriteLine("Lista vuota.");
            }
            else
            {
                double max = listaNumeri[0];

                foreach (double n in listaNumeri)
                {
                    if (n > max)
                    {
                        max = n;
                    }
                }

                Console.WriteLine("Massimo: " + max);
            }
            break;

        case 8:
            if (listaNumeri.Count == 0)
            {
                Console.WriteLine("Lista vuota.");
            }
            else
            {
                double min = listaNumeri[0];

                foreach (double n in listaNumeri)
                {
                    if (n < min)
                    {
                        min = n;
                    }
                }

                Console.WriteLine("Minimo: " + min);
            }
            break;

        case 9:
            Console.WriteLine("Numero elementi: " + listaNumeri.Count);
            break;

        case 10:
            if (listaNumeri.Count == 0)
            {
                Console.WriteLine("Lista vuota.");
            }
            else
            {
                Console.Write("Inserisci valore: ");
                double valore = Convert.ToDouble(Console.ReadLine());

                foreach (double n in listaNumeri)
                {
                    if (n > valore)
                    {
                        Console.WriteLine(n);
                    }
                }
            }
            break;

        case 11:
            if (listaNumeri.Count == 0)
            {
                Console.WriteLine("Lista vuota.");
            }
            else
            {
                Console.Write("Numero da cercare: ");
                double cerca = Convert.ToDouble(Console.ReadLine());

                bool trovato = false;

                for (int i = 0; i < listaNumeri.Count; i++)
                {
                    if (listaNumeri[i] == cerca)
                    {
                        Console.WriteLine("Numero trovato in posizione: " + i);
                        trovato = true;
                    }
                }

                if (!trovato)
                {
                    Console.WriteLine("Numero non trovato.");
                }
            }
            break;

    }

} while (scelta != 12);

Console.WriteLine("Programma terminato.");