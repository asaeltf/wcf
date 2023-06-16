using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de EmailPersonaRequest
/// </summary>
public class EmailPersonaRequest
{
    public EmailPersonaRequest(string Mensaje, string Correo)
    {
       this.Correo = Correo;
        this.Mensaje = Mensaje;
    }
    public string Mensaje { get; set; }
    public string Correo { get; set; }
}