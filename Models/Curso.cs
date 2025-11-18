using System;
using System.Collections.Generic;

namespace Projetositedeestudo.Models;

public partial class Curso
{
    public int Id { get; set; }

    public string? Titulo { get; set; }

    public string? NivelDificuldade { get; set; }

    public string? Descricao { get; set; }

    public int? CargaHoraria { get; set; }

    public int? MateriaId { get; set; }

    public virtual ICollection<Conteudo> Conteudos { get; set; } = new List<Conteudo>();

    public virtual Materium? Materia { get; set; }
}
