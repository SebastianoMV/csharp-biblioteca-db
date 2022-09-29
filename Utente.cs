// See https://aka.ms/new-console-template for more information
public class Utente
{
    public string Nome
    { get; set; }
    public string Cognome
    { get; set; }
    public string Email
    { get; set; }
    public string Password
    { get; set; }
    public string Telefono
    { get; set; }

    public Utente(string nome, string cognome, string email, string password, string telefono)
    {
        this.Nome = nome;
        this.Cognome = cognome;
        this.Email = email;
        this.Password = password;
        this.Telefono = telefono;
    }
}
