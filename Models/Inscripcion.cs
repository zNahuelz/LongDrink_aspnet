using System;
using System.Collections.Generic;

namespace LongDrink_aspnet.Models;

public partial class Inscripcion
{
    public int IdCurso { get; set; }

    public int IdAlumno { get; set; }

    public DateTime FechaInscripcion { get; set; }

    public DateTime FechaInicio { get; set; }

    public DateTime FechaFinal { get; set; }

    public bool EnCurso { get; set; }

    public virtual Alumno IdAlumnoNavigation { get; set; } = null!;

    public virtual Curso IdCursoNavigation { get; set; } = null!;
}
