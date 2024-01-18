using System.ComponentModel.DataAnnotations;

namespace API_Reconnect.Models
{
    public class Contrato
    {
        [Key]
        public int Id { get; set; }
        public string Endereco { get; set; }
        public DateTime DataHora { get; set; }
        public bool Concluido { get; set; }

        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        public int ServicoId { get; set; }
        public Servico Servico { get; set; }
    }
}
