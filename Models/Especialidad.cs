using System;
using System.Collections.Generic;

namespace LongDrink_aspnet.Models;

public partial class Especialidad
{
    public int IdEspecialidad { get; set; }

    public int IdProfesor { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual Profesor IdProfesorNavigation { get; set; } = null!;
}
