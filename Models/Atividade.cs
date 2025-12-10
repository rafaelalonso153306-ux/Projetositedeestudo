using System;
using System.Collections.Generic;

namespace Projetositedeestudo.Models;

public partial class Atividade
{
    public int Id { get; set; }

    public string Titulo { get; set; } = null!;

    public string? Descricao { get; set; }

    public int UsuarioId { get; set; }

    public int ConteudoId { get; set; }

<<<<<<< HEAD
    public string? Status { get; set; }

    public DateTime? DataConclusao { get; set; }

    public virtual ICollection<AtividadesUsuario> AtividadesUsuarios { get; set; } = new List<AtividadesUsuario>();

    public virtual Conteudo Conteudo { get; set; } = null!;

    public virtual Usuario Usuario { get; set; } = null!;
}
=======
    public virtual Usuario? Usuario { get; set; }
}
>>>>>>> c6934cb2cc39ab4515a1ea79937d9d760033f168
