using System;
using System.Collections.Generic;

namespace LongDrink_aspnet.Models;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    public string NombreUsuario { get; set; } = null!;

    public string Contrasena { get; set; } = null!;

    public bool Permisos { get; set; }
}
