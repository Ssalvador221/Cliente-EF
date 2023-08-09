using Treinar.Models;

namespace Treinar.Data.ClienteDbContext.Entidades;

public class Cliente
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public string FirstName { get; set; }
    
    public string LastName { get; set; }
    
    public DateTime? Idade { get; set; }

    public int IdadeDoCliente { get
    {
        if (!Idade.HasValue) return 0;
        var age = DateTime.Now.Year - Idade.Value.Year;
        if (new DateOnly().DayOfYear < Idade.Value.DayOfYear)
            age = age - 1;
        return age;
    } }

}
