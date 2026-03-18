Console.WriteLine("Hello, World!");

// molto simile a Javascript (java)
String? email;
// assegnamo la variabile
email = "rocco.siffredi@gmail.com";
//c'è tutto
Console.WriteLine("Lunghezza stringa: " + email.Length);

//c'è la ricerca delle sottostringhe
Int32 indiceChiocciola;
indiceChiocciola = email.IndexOf("@");
if (indiceChiocciola == -1)
{
    Console.WriteLine("La stringa non contiene la chiocciola");
}
else
{
    Console.WriteLine("La chiocciola è presente");
}

// substring
// posso estrarre una sottostringa da una stringa 
String messaggio = "ciao amici tutto bene";
// vorrei estrarre una parte della stringa messaggio
String sottostringa = messaggio.Substring(5, 9);
Console.WriteLine("La sottostringa è: " + sottostringa);

email = "rocco.siffredi@gmail.com";
// estrarre e stampare solo lo username: "rocco.siffredi"
// ed estrarre anche il server di posta: "gmail.com"
Console.WriteLine("Username: " + email.Substring(0, indiceChiocciola));
Console.WriteLine("Server di posta: " + email.Substring(indiceChiocciola + 1));

// come scorriamo e visualizziamo i singoli caratteri 
// di una stringa
String Citta = "Treviso";
// metodo da anzianzi
for (Int32 i = 0; i < Citta.Length; i++)
{
    Console.WriteLine(Citta.Substring(i, 1));
}

// for moderno per giovani 
foreach (char carattere in Citta)
{
    Console.WriteLine(carattere);
}


// metodi o funzioni molto utili 
char lettera = 'e';
// vorrei vedere se lettera è consonante o vocale
string vocali ="aeiouAEIOU";

if (vocali.Contains(lettera))
{
    Console.WriteLine("La lettera è una vocale");
}
else
{
    Console.WriteLine("La lettera è una consonante");
}