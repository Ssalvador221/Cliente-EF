using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Treinar.Data.Entidades;

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
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    [DisplayName("Idade")]
    public DateTime Idade { get; set; } = new DateTime(1930, 1, 1);
    
    public Guid? CepClienteId { get; set; }


}

/*public class CadastroClienteViewModel
{
    public Guid Id { get; set; }
    public ClienteViewModel ClienteViewModel { get; set; } = new();
    public CepClienteViewModel CepViewModel{ get; set; } = new();
}*/

public class CepClienteViewModel 
{
    public Guid CepClienteViewModelId { get; set; }
    
    [MaxLength(8)]
    [Required(ErrorMessage = "Por Favor informe seu {0}")]
    [Display(Name = "CEP")]
    public string Cep { get; set; }

    [Display(Name = "Estado")] public string State { get; set; }

    [Display(Name = "Cidade")] public string City { get; set; }

    [Display(Name = "Bairro")] public string Neighborhood { get; set; }

    [Display(Name = "Rua")] public string Street { get; set; }
}

