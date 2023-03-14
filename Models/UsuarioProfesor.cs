using System;
using System.Collections.Generic;

namespace LongDrink_aspnet.Models;

public partial class UsuarioProfesor
{
    public int IdProfesor { get; set; }

    public int IdUsuario { get; set; }

    public virtual Profesor IdProfesorNavigation { get; set; } = null!;

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
}
