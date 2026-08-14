namespace SistemaAgendamentoCRUD.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        public string? Nome { get; set; }

        public string? Telefone { get; set; }

        // O '?' aqui é ESSENCIAL para o ASP.NET não exigir essa lista na hora do formulário!
        public virtual ICollection<Agendamento>? Agendamentos { get; set; }
    }
}