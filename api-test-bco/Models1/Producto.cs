using System;
using System.Collections.Generic;

namespace api_test_bco.Models1;

public partial class Producto
{
    public int IdProducto { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public decimal Precio { get; set; }

    public int Cantidad { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public bool? Estado { get; set; }
}
