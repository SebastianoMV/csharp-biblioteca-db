// See https://aka.ms/new-console-template for more information
public class Prestito
{
    public string Periodo
        { get; set; }

    public string NomeUtente
        { get; set; }

    public string CognomeUtente
        { get; set; }

    public Documento Documento
    { get; set; }

    public Prestito(string periodo, string nomeUtente, string cognomeUtente, Documento documento)
    {
        this.Periodo = periodo;
        this.NomeUtente = nomeUtente;
        this.CognomeUtente = cognomeUtente;
        this.Documento = documento;
        
    }

    
}