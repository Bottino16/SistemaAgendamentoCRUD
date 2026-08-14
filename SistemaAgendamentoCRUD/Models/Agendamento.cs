using System;

namespace SistemaAgendamentoCRUD.Models
{
    public class Agendamento
    {
        public int Id { get; set; }

        public DateTime DataHora { get; set; }

        public int UsuarioId { get; set; }

        public virtual Usuario? Usuario { get; set; }

        public int ServicoId { get; set; }

        public virtual Servico? Servico { get; set; }
    }
}