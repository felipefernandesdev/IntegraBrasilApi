using System.Text.Json.Serialization;

namespace IntegraBrasilApi.Dtos
{
    public class EnderecoResponse
    {
        public string? Cep { get; set; }
        public string? State { get; set; }
        public string? City { get; set; }
        public string? Neighborhood { get; set; }
        public string? Street { get; set; }

        [JsonIgnore]
        public string? Service { get; set; }
    }
}