using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Descripción breve de ActivoEmpleado
/// </summary>
public class ActivoEmpleado
{
    [DataMember]
    public int id { get; set; }
    [DataMember]
    public int idEmpleado { get; set; }
    [DataMember]
    public int idActivo { get; set; }
    [DataMember]
    public DateTime fechaAsigancion { get; set; }
    [DataMember]
    public DateTime fechaEntrega { get; set; }
    [DataMember]
    public DateTime fechaLiberacion { get; set; }
}