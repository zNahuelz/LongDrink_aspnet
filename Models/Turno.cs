using System;
using System.Collections.Generic;

namespace LongDrink_aspnet.Models;

public partial class Turno
{
    public int IdTurno { get; set; }

    public int IdCurso { get; set; }

    public string Nombre { get; set; } = null!;

    public TimeSpan HoraInicio { get; set; }

    public TimeSpan HoraFinal { get; set; }

    public virtual Curso IdCursoNavigation { get; set; } = null!;
}
