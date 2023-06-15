using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Descripción breve de Persona
/// </summary>
/// 

[DataContract]
public class Persona
{
    [DataMember]
    public int id { get; set; }
    [DataMember]
    public string nombre { get; set; }
    [DataMember]
    public string apellidos { get; set; }
    public int numeroEmpleado { get; set; }
    [DataMember]
    public string correo { get; set; }
    [DataMember]
    public string curp { get; set;}
    [DataMember]
    public bool estatus { get; set; }
}