// See https://aka.ms/new-console-template for more information
public class Documento
{
    string codice;
    string titolo;
    int anno;
    string settore;
    bool stato;
    int scaffale;
    string autore;

    public Documento(string codice, string titolo, int anno, string settore, bool stato, int scaffale, string autore)
    {
        this.codice = codice;
        this.titolo = titolo;
        this.anno = anno;
        this.settore = settore;
        this.stato = stato;
        this.scaffale = scaffale;
        this.autore = autore;
    }
    public string GetCodice
    {
        get { return codice; }
    }

    public string GetTitolo
    {
        get { return titolo; }
    }

}

class Libro : Documento
{
    int numeroPagine;
    public Libro(string codice, string titolo, int anno, string settore, bool stato, int scaffale, string autore, int numeroPagine) : base(codice, titolo, anno, settore, stato, scaffale, autore)
    {
        this.numeroPagine = numeroPagine;
    }
}

class Dvd : Documento
{
    int durata;

    public Dvd(string codice, string titolo, int anno, string settore, bool stato, int scaffale, string autore, int durata) : base(codice, titolo, anno, settore, stato, scaffale, autore)
    {

        this.durata = durata;
    }
};