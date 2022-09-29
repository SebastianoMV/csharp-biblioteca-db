// See https://aka.ms/new-console-template for more information
using System;
using System.IO;


Console.WriteLine("  ");
List<Utente> utentes = new List<Utente>();
utentes.Add(new Utente("Ugo", "De Ughi", "ugo@gmail.com", "qwerty1", "345223443"));

List<Prestito> prestito = new List<Prestito>();

List <Dvd> dvds = new List<Dvd>();
dvds.Add(new Dvd("12331", "Signore degli Anelli", 2000, "Fantasy", false, 5, "Peter Jackson", 120));
dvds.Add(new Dvd("1444", "Le Follie Dell'imperatore", 2000, "Commedia", false, 8, "Mark Dindal", 78));
dvds.Add(new Dvd("211111", "Il cavaliere oscuro", 2008, "Azione", false, 20, "Christopher Nolan", 152));

List <Libro> libros = new List<Libro>();
libros.Add(new Libro("9780261103665", "Il Silmarillion", 1977, "Fantasy", false, 5, "Tolkien", 1000));
libros.Add(new Libro("9788877827029", "Harry Potter", 1997, "Fantasy", false, 3, "J. K. Rowling", 1000));
libros.Add(new Libro("9780151660346", "1984", 1949, "Distopico", false, 3, "George Orwell", 1000));

//LOGIN

Console.WriteLine("Vuoi loggarti o registrarti? [login/registrati]");
string sceltalog = Console.ReadLine();
if(sceltalog == "login")
{
    Console.WriteLine("Inserisci la Mail");
    foreach (Utente utente in utentes)
    {
        if (Console.ReadLine() == utente.Email)
        {
            Console.WriteLine("Inserisci la Password");
            if (Console.ReadLine() == utente.Password)
            {
                Console.WriteLine("Benvenuto "+ utente.Nome);
            }
        }
    }
}else if(sceltalog == "registrati")
{
    Console.WriteLine("Inserisci nome");
    string newNome = Console.ReadLine();

    Console.WriteLine("Inserisci cognome");
    string newCognome = Console.ReadLine();

    Console.WriteLine("Inserisci email");
    string newEmail = Console.ReadLine();

    Console.WriteLine("Inserisci password");
    string newPassword = Console.ReadLine();

    Console.WriteLine("Inserisci numero di telefono");
    string newNumero = Console.ReadLine();

    utentes.Add(new Utente(newNome, newCognome, newEmail, newPassword, newNumero));

    Console.WriteLine("Benvenuto " + newNome + " " + newCognome);
}





//RICERCA E PRESTITO

string ricerca;
Console.WriteLine("Vuoi cercare un libro o un dvd? [libri/dvd]");
ricerca = Console.ReadLine();
if (ricerca == "dvd")
{
    Console.WriteLine("Cerchi per Titolo o per Codice? [titolo/codice]");
    string ricercaTipo = Console.ReadLine();
    if(ricercaTipo == "titolo")
    {
        Console.WriteLine("Inserisci un Titolo");
        string titoloRicerca = Console.ReadLine();
        foreach (Dvd dvd in dvds)
        {
            if (dvd.GetTitolo.ToLower().Contains(titoloRicerca))
            {
                Console.WriteLine("Vuoi " + dvd.GetTitolo + " in prestito? [si/no]");
                string scelta = Console.ReadLine();
                if (scelta == "si")
                {
                    prestito.Add(new Prestito("dal 20/9 al 20/10", "Ugo", "De Ughi", dvd));
                    
                }
            };
       }
        
    }else if(ricercaTipo == "codice")
    {
        Console.WriteLine("Inserisci un Codice");
        string codiceRicerca = Console.ReadLine();
        foreach (Dvd dvd in dvds)
        {
            if (dvd.GetCodice.Contains(codiceRicerca))
            {
                Console.WriteLine("Vuoi " + dvd.GetTitolo + " in prestito? [si/no]");
                string scelta = Console.ReadLine();
                if (scelta == "si")
                {
                    prestito.Add(new Prestito("dal 20/9 al 20/10", "Ugo", "De Ughi", dvd));

                }
            };

        }
    }
    else
    {
        Console.WriteLine("Ricerca non valida");
    }
    

}
else if(ricerca == "libri" || ricerca == "libro")
{
    Console.WriteLine("Cerchi per Titolo o per Codice? [titolo/codice]");
    string ricercaTipo = Console.ReadLine();
    if (ricercaTipo == "titolo")
    {
        Console.WriteLine("Inserisci un Titolo");
        string titoloRicerca = Console.ReadLine();
        foreach (Libro libro in libros)
        {
            if (libro.GetTitolo.ToLower().Contains(titoloRicerca))
            {
                Console.WriteLine("Vuoi " + libro.GetTitolo + " in prestito? [si/no]");
                string scelta = Console.ReadLine();
                if (scelta == "si")
                {
                    prestito.Add(new Prestito("dal 20/9 al 20/10", "Ugo", "De Ughi", libro));

                }
            };

        }

    }
    else if (ricercaTipo == "codice")
    {
        Console.WriteLine("Inserisci un Codice");
        string codiceRicerca = Console.ReadLine();
        foreach (Libro libro in libros)
        {
            if (libro.GetCodice.Contains(codiceRicerca))
            {
                Console.WriteLine("Vuoi " + libro.GetTitolo + " in prestito? [si/no]");
                string scelta = Console.ReadLine();
                if (scelta == "si")
                {
                    prestito.Add(new Prestito("dal 20/9 al 20/10", "Ugo", "De Ughi", libro));

                }
            };

        }
    }
    else
    {
        Console.WriteLine("Ricerca non valida");
    }

}
else
{
    Console.WriteLine("Campo non valido");
}


Console.WriteLine("Se vuoi cercare i tuoi prestiti inserisci il tuo nome e cognome");
Console.WriteLine("nome:");
string nome = Console.ReadLine();
Console.WriteLine("cognome");
string cognome = Console.ReadLine();

foreach(Prestito prestit in prestito)
{
    if(prestit.NomeUtente == nome || prestit.CognomeUtente == cognome)
    {
        Console.WriteLine("Hai preso in prestito " + prestit.Documento.GetTitolo);
    }
}



void login()
{
 
}