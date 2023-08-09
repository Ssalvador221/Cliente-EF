using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Treinar.Data.ClienteDbContext.Entidades;

namespace Treinar.Models;

public class ClienteViewModel : Cliente
{

    [Required(ErrorMessage = "Por Favor insira seu primeiro Nome!")]
    [DisplayName("First Name")]
    public string FirstName { get; set; }
    
    [Required(ErrorMessage = "Por Favor insira seu Sobrenome!")]
    [DisplayName("Last Name")]
    public string LastName { get; set; }
    
    [Required(ErrorMessage = "Por Favor insira sua Idade!")]
    [DisplayName("Idade")]
    public DateTime Idade { get; set; }
    
    
}