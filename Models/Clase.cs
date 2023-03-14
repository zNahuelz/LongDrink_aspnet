using System;
using System.Collections.Generic;

namespace LongDrink_aspnet.Models;

public partial class Clase
{
    public int IdClase { get; set; }

    public int IdCurso { get; set; }

    public string Nombre { get; set; } = null!;

    public string Guia { get; set; } = null!;

    public virtual Curso IdCursoNavigation { get; set; } = null!;
}
