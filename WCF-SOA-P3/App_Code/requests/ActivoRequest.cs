using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de ActivoRequest
/// </summary>
public class ActivoRequest
{
    public ActivoRequest(string Nombre, string Descripcion, bool Estatus) { 
        this.Nombre = Nombre;
        this.Descripcion = Descripcion;
        this.Estatus = Estatus;
    }
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public bool Estatus { get; set; }
}