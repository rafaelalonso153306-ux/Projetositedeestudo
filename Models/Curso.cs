namespace Projetositedeestudo.Models
{
    public partial class Curso
    {
        public int Id { get; set; }

        public string? Titulo { get; set; }

        public string? NivelDificuldade { get; set; }

        public string? Descricao { get; set; }

        public int? CargaHoraria { get; set; }

        public int? MateriaId { get; set; }

        public string? Imagem { get; set; }

        public virtual ICollection<Conteudo> Conteudos { get; set; } = [];

        public virtual Materium? Materia { get; set; }
    }
}
