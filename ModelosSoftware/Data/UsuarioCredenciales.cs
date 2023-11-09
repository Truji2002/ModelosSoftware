using System.Text.Json.Serialization;

namespace ModelosSoftware.Data
{
    public class UsuarioCredenciales
    {
        [JsonPropertyName("usuario")]
        public string? Username { get; set; }

        [JsonPropertyName("password")]
        public string? Password { get; set; }
    }
}
