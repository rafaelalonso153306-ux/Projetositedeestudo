using System;
using System.Collections.Generic;

namespace Projetositedeestudo.Models;

public partial class Usuario
{
    public int Id { get; set; }

    public string Nome { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Senha { get; set; } = null!;

    public string NivelAcesso { get; set; } = null!;

    public string? Avatar { get; set; }

    public virtual ICollection<Atividade> Atividades { get; set; } = new List<Atividade>();

    public virtual ICollection<AtividadesUsuario> AtividadesUsuarios { get; set; } = new List<AtividadesUsuario>();
}
