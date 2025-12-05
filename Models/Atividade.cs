using System;
using System.Collections.Generic;

namespace Projetositedeestudo.Models;

public partial class Atividade
{
    public int Id { get; set; }

    public double? Nota { get; set; }

    public int? UsuarioId { get; set; }

    public int? ConteudoId { get; set; }

    public virtual Conteudo? Conteudo { get; set; }

    public virtual Usuario? Usuario { get; set; }
}
