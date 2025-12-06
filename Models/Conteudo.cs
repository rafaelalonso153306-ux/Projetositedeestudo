namespace Projetositedeestudo.Models
{
    public partial class Conteudo
    {
        public int Id { get; set; }

        public int? CursoId { get; set; }

        public string? Nome { get; set; }

        public virtual ICollection<Atividade> Atividades { get; set; } = [];

        public virtual Curso? Curso { get; set; }
    }
}
