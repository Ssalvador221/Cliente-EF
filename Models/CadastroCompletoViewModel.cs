namespace Treinar.Models;

public class CadastroCompletoViewModel
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public ClienteViewModel ClienteViewModel { get; set; } = new();
    public CepClienteViewModel CepClienteViewModel { get; set; } = new();
}