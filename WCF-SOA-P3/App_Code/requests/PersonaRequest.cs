using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de PersonaRequest
/// </summary>
public class PersonaRequest
{
    public PersonaRequest(int numeroEmpleado, bool estatus,
        DateTime fechaIngreso, string nombre, string apellidos,
        string curp, string correo, DateTime FechaNacimiento)
    {
        this.numeroEmpleado = numeroEmpleado;
        this.estatus = estatus;
        this.fechaIngreso = fechaIngreso;
        this.nombre = nombre;
        this.apellidos = apellidos;
        this.curp = curp;
        this.correo = correo;
        this.FechaNacimiento = FechaNacimiento;
    }
    public int numeroEmpleado { get; set; }
    public bool estatus { get; set; }
    public DateTime fechaIngreso { get; set; }
    public string nombre { get; set; }
    public string apellidos { get; set; }
    public string curp { get; set; }
    public string correo { get; set; }
    public DateTime FechaNacimiento { get; set; }
}