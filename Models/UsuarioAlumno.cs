using System;
using System.Collections.Generic;

namespace LongDrink_aspnet.Models;

public partial class UsuarioAlumno
{
    public int IdUsuario { get; set; }

    public int IdAlumno { get; set; }

    public virtual Alumno IdAlumnoNavigation { get; set; } = null!;

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
}
