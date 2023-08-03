using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Treinar.Models;

public class ClienteViewModel
{

    [Required(ErrorMessage = "Por Favor insira seu primeiro Nome!")]
    [DisplayName("First Name")]
    public string FirstName { get; set; }
    
    [Required(ErrorMessage = "Por Favor insira seu Sobrenome!")]
    [DisplayName("Last Name")]
    public string LastName { get; set; }
    
    [Required(ErrorMessage = "Por Favor insira sua Idade!")]
    [DisplayName("Idade")]
    public int Idade { get; set; }
}