namespace Projetositedeestudo.Models
{
    public partial class Materia
    {
        public int Id { get; set; }
        public string? Nome { get; set; }

        public virtual ICollection<Curso> Cursos { get; set; } = [];
        public virtual ICollection<MateriaUsuario> MateriaUsuarios { get; set; } = [];
    }
}
