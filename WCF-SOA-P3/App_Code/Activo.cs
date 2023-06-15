using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Descripción breve de Activo
/// </summary>
public class Activo
{
    [DataMember]
    public int Id { get; set; }
    [DataMember]
    public string Nombre { get; set; }
    [DataMember]
    public string Descripcion { get; set; }
    [DataMember]
    public bool Estatus { get; set; }
}