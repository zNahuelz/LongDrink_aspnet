using System;
using System.Collections.Generic;

namespace LongDrink_aspnet.Models;

public partial class Alumno
{
    public int IdAlumno { get; set; }

    public string Nombre { get; set; } = null!;

    public string ApMaterno { get; set; } = null!;

    public string ApPaterno { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Dni { get; set; } = null!;
}
