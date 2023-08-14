using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Treinar.Data.Entidades;

public class CepCliente
{
    
    public Guid Id { get; set; } = new Guid();
    
    [JsonPropertyName("cep")]
    public string? cep { get; set; }
    
    [JsonPropertyName("state")]
    public string state { get; set; }
    
    [JsonPropertyName("city")]
    public string city { get; set; }

    [JsonPropertyName("neighborhood")]
    public string? neighborhood { get; set; }

    [JsonPropertyName("street")]
    public string? street { get; set; }
    
}