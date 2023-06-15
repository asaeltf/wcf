using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de ActivoEmpleadoRequest
/// </summary>
public class ActivoEmpleadoRequest
{
    public ActivoEmpleadoRequest(int identificadorEmpleado, int identificadoActivo, DateTime fechaAsignacion, DateTime fechaLiberacion, DateTime fechaEntrega)
    {
        this.identificadorEmpleado = identificadorEmpleado;
        this.identificadoActivo = identificadoActivo;
        this.fechaAsignacion = fechaAsignacion;
        this.fechaLiberacion = fechaLiberacion;
        this.fechaEntrega = fechaEntrega;
    }

    public int identificadorEmpleado { get; set; }
    public int identificadoActivo { get; set; }
    public DateTime fechaAsignacion { get; set; }
    public DateTime fechaLiberacion { get; set; }
    public DateTime fechaEntrega { get; set; }

}