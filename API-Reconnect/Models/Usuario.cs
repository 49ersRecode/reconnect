using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace API_Reconnect.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Senha { get; set; }
        public string Telefone { get; set; }
        public string Profissao { get; set; }
        public string Cpf { get; set; }
        public string Endereco { get; set; }
        public DateTime datNascimento { get; set;}

        [JsonIgnore]
        public List<Servico> Servicos { get; set; }
        [JsonIgnore]
        public List<Contrato> Contratos { get; set; }


    }
}
