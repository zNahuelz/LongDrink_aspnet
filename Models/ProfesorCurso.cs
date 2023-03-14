using System;
using System.Collections.Generic;

namespace LongDrink_aspnet.Models;

public partial class ProfesorCurso
{
    public int IdProfesor { get; set; }

    public int IdCurso { get; set; }

    public DateTime FechaInicio { get; set; }

    public DateTime FechaFinal { get; set; }

    public virtual Curso IdCursoNavigation { get; set; } = null!;

    public virtual Profesor IdProfesorNavigation { get; set; } = null!;
}
