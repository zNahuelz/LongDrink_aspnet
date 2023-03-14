using System;
using System.Collections.Generic;

namespace LongDrink_aspnet.Models;

public partial class Curso
{
    public int IdCurso { get; set; }

    public string Nombre { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public double Costo { get; set; }

    public byte Duracion { get; set; }

    public virtual ICollection<Clase> Clases { get; } = new List<Clase>();

    public virtual ICollection<Turno> Turnos { get; } = new List<Turno>();
}
