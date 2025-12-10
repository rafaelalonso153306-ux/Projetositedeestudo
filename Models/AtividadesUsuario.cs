using System;
using System.Collections.Generic;

namespace Projetositedeestudo.Models;

public partial class AtividadesUsuario
{
    public int Id { get; set; }

    public int? UsuarioId { get; set; }

    public int? AtividadeId { get; set; }

    public virtual Atividade? Atividade { get; set; }

    public virtual Usuario? Usuario { get; set; }
}
