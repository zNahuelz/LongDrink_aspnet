using System;
using System.Collections.Generic;

namespace LongDrink_aspnet.Models;

public partial class Profesor
{
    public int IdProfesor { get; set; }

    public string Nombre { get; set; } = null!;

    public string ApMaterno { get; set; } = null!;

    public string ApPaterno { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Dni { get; set; } = null!;

    public virtual ICollection<Especialidad> Especialidads { get; } = new List<Especialidad>();
}
