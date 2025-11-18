using System;
using System.Collections.Generic;

namespace Projetositedeestudo.Models;

public partial class Conteudo
{
    public int Id { get; set; }

    public int? CursoId { get; set; }

    public string? Nome { get; set; }

    public virtual ICollection<Atividade> Atividades { get; set; } = new List<Atividade>();

    public virtual Curso? Curso { get; set; }
}
