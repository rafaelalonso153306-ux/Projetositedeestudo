using System;
using System.Collections.Generic;

namespace Projetositedeestudo.Models;

public partial class Materium
{
    public int Id { get; set; }

    public string Titulo { get; set; } = null!;

    public string? Descricao { get; set; }

    public string? Imagem { get; set; }

    public virtual ICollection<Curso> Cursos { get; set; } = new List<Curso>();
}
