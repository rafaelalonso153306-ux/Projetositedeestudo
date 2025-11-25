using System;
using System.Collections.Generic;

namespace Projetositedeestudo.Models;

public partial class MateriaUsuario
{
    public int Id { get; set; }

    public int? UsuarioId { get; set; }

    public int? MateriaId { get; set; }

    public virtual Materia? Materia { get; set; }

    public virtual Usuario? Usuario { get; set; }
}
