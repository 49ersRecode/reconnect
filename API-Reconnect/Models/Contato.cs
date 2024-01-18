using System.ComponentModel.DataAnnotations;

namespace API_Reconnect.Models
{
    public class Contato
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Mensagem { get; set; }

        public int ServicoId { get; set; }
        public Servico Servico { get; set; }
    }
}
