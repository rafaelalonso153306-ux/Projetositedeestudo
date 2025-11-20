using System;
using System.Collections.Generic;

namespace Projetositedeestudo.Models;

public partial class Usuario
{
    
    public int Id { get; set; }

    public string? Nome { get; set; }

    public string? Email { get; set; }

    public string? Senha { get; set; }

    public virtual ICollection<Atividade> Atividades { get; set; } = new List<Atividade>();

    public virtual ICollection<MateriaUsuario> MateriaUsuarios { get; set; } = new List<MateriaUsuario>();
}

public class DbSet<T>
{
    internal dynamic ToList()
    {
        throw new NotImplementedException();
    }
}