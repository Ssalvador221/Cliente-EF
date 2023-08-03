namespace Treinar.Data.ClienteDbContext.Entidades;

public class Cliente
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public string FirstName { get; set; }
    
    public string LastName { get; set; }
    
    public int Idade { get; set; }
    
    
}