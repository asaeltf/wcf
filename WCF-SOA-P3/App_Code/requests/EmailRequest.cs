using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de EmailRequest
/// </summary>
public class EmailRequest
{
    public EmailRequest(string mensaje)
    {
        this.mensaje = mensaje;
    }
    public string mensaje { get; set; }
}