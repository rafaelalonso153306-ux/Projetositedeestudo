using System;
using System.Collections.Generic;

namespace Projetositedeestudo.Models;

public partial class Materium
{
    public int Id { get; set; }

    public string? Nome { get; set; }

    public virtual ICollection<Curso> Cursos { get; set; } = new List<Curso>();

    public virtual ICollection<MateriaUsuario> MateriaUsuarios { get; set; } = new List<MateriaUsuario>();
}
