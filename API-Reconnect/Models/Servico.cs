using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace API_Reconnect.Models
{
    public class Servico
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set;}
        
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set;}

        [JsonIgnore]
        public List<Contrato> Contratos { get; set; }

        [JsonIgnore]
        public List<Contato> Contatos { get; set; }
    }
}
