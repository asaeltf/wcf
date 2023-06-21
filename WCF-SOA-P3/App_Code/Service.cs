using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
public class Service : IService
{
	public string GetData(int value)
	{
		return string.Format("You entered: {0}", value);
	}

	public string GetDataPersonabyId(int id)
	{
		string data = "";
		try
		{
			HttpClient client = new HttpClient();
			client.DefaultRequestHeaders.Accept.Clear();
			
			var response = client.GetAsync("http://api-soa.somee.com/api-soa/personas").Result;

			if (response.IsSuccessStatusCode)
			{
                // response.Content.ReadAsStringAsync().Result;
                var result = response.Content.ReadAsStringAsync().Result;

				List<Persona> personas = JsonConvert.DeserializeObject<List<Persona>>(result);

				var person = personas.FirstOrDefault(x => x.id == id);

				data = JsonConvert.SerializeObject(person);
			}
		}
		catch(Exception e)
		{
			data =  e.Message;
		}

		return data;
	}


    // DELETE
    public string EliminarActivoEmpleado(int id)
    {
        string data = "";
        try
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();

            var response = client.DeleteAsync("https://soa-p2-bellako-production.up.railway.app/ActivoEmpleado/" + id).Result;

            if (response.IsSuccessStatusCode)
            {
                // response.Content.ReadAsStringAsync().Result;
                var result = response.Content.ReadAsStringAsync().Result;

                //Activo activos = JsonConvert.DeserializeObject<Activo>(result);
                data = result;
                //var activo = activos;

                //data = JsonConvert.SerializeObject(activo);
            }
        }
        catch (Exception e)
        {
            data = e.Message;
        }

        return data;
    }

    public string EliminarEmpleado(int id)
    {
        string data = "";
        try
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();

            var response = client.DeleteAsync("https://soa-p2-bellako-production.up.railway.app/Personas/" + id).Result;

            if (response.IsSuccessStatusCode)
            {
                // response.Content.ReadAsStringAsync().Result;
                var result = response.Content.ReadAsStringAsync().Result;

                //Activo activos = JsonConvert.DeserializeObject<Activo>(result);
                data = result;
                //var activo = activos;

                //data = JsonConvert.SerializeObject(activo);
            }
        }
        catch (Exception e)
        {
            data = e.Message;
        }

        return data;
    }

    public string ObtenerEmpleados()
    {
        string data = "";
        try
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();

            var response = client.GetAsync("https://soa-p2-bellako-production.up.railway.app/Personas").Result;

            if (response.IsSuccessStatusCode)
            {
                // response.Content.ReadAsStringAsync().Result;
                var result = response.Content.ReadAsStringAsync().Result;

                List<Persona> personas = JsonConvert.DeserializeObject<List<Persona>>(result);



                data = JsonConvert.SerializeObject(personas);
            }
        }
        catch (Exception e)
        {
            data = e.Message;
        }

        return data;
    }

    public string ObtenerEmpleadosActivos()
	{
        string data = "";
        try
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();

            var response = client.GetAsync("https://soa-p2-bellako-production.up.railway.app/ActivoEmpleado").Result;

            if (response.IsSuccessStatusCode)
            {
                // response.Content.ReadAsStringAsync().Result;
                var result = response.Content.ReadAsStringAsync().Result;

                List<ActivoEmpleado> personas = JsonConvert.DeserializeObject<List<ActivoEmpleado>>(result);

                

                data = JsonConvert.SerializeObject(personas);
            }
        }
        catch (Exception e)
        {
            data = e.Message;
        }

        return data;
    }

	public string ObtenerActivos() 
	{
        string data = "";
        try
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();

            var response = client.GetAsync("https://soa-p2-bellako-production.up.railway.app/Activo").Result;

            if (response.IsSuccessStatusCode)
            {
                // response.Content.ReadAsStringAsync().Result;
                var result = response.Content.ReadAsStringAsync().Result;

                List<Activo> activos = JsonConvert.DeserializeObject<List<Activo>>(result);
                data = JsonConvert.SerializeObject(activos);
            }
        }
        catch (Exception e)
        {
            data = e.Message;
        }

        return data;
    }
    public string RegistrarActivo(string Nombre, string Descripcion, bool Estatus)
    {
        ActivoRequest request = new ActivoRequest(Nombre, Descripcion, Estatus);
        var requestContent = JsonContent.Create(request);
        string data = "";
        try
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();

            var response = client.PostAsync("https://soa-p2-bellako-production.up.railway.app/Activo", requestContent).Result;

            if (response.IsSuccessStatusCode)
            {
                // response.Content.ReadAsStringAsync().Result;
                var result = response.Content.ReadAsStringAsync().Result;

                Activo activos = JsonConvert.DeserializeObject<Activo>(result);

                var activo = activos;

                data = JsonConvert.SerializeObject(activo);
            }
        }
        catch (Exception e)
        {
            data = e.Message;
        }

        return data;
    }
    public string RegistrarEmpleado(int numeroEmpleado, bool estatus,
        DateTime fechaIngreso, string nombre, string apellidos,
        string curp, string correo, DateTime FechaNacimiento)
    {
        PersonaRequest request = new PersonaRequest(numeroEmpleado, estatus, fechaIngreso, nombre, apellidos, curp, correo, FechaNacimiento);
        var requestContent = JsonContent.Create(request);
        string data = "";
        try
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();

            var response = client.PostAsync("https://soa-p2-bellako-production.up.railway.app/Personas", requestContent).Result;

            if (response.IsSuccessStatusCode)
            {
                // response.Content.ReadAsStringAsync().Result;
                var result = response.Content.ReadAsStringAsync().Result;

                Persona activos = JsonConvert.DeserializeObject<Persona>(result);

                var activo = activos;

                data = JsonConvert.SerializeObject(activo);
            }
        }
        catch (Exception e)
        {
            data = e.Message;
        }

        return data;
    }

    public string RegistrarActivoEmpledao(int identificadorEmpleado, int identificadoActivo, DateTime fechaAsignacion, DateTime fechaLiberacion, DateTime fechaEntrega)
    {
        ActivoEmpleadoRequest request = new ActivoEmpleadoRequest(identificadorEmpleado, identificadoActivo, fechaAsignacion, fechaLiberacion, fechaEntrega);
        var requestContent = JsonContent.Create(request);
        string data = "";
        try
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();

            var response = client.PostAsync("https://soa-p2-bellako-production.up.railway.app/ActivoEmpleado", requestContent).Result;

            if (response.IsSuccessStatusCode)
            {
                // response.Content.ReadAsStringAsync().Result;
                var result = response.Content.ReadAsStringAsync().Result;

                //Persona activos = JsonConvert.DeserializeObject<Persona>(result);

                //var activo = activos;

                data = JsonConvert.SerializeObject(result);
            }
        }
        catch (Exception e)
        {
            data = e.Message;
        }

        return data;
    }
    public string AvisarEmpleado(string Mensaje, string Correo)
    {
        EmailPersonaRequest request = new EmailPersonaRequest(Mensaje, Correo);
        var requestContent = JsonContent.Create(request);
        string data = "";
        try
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();

            var response = client.PostAsync("https://soa-p2-bellako-production.up.railway.app/Email/avisarEntrega", requestContent).Result;

            if (response.IsSuccessStatusCode)
            {
                // response.Content.ReadAsStringAsync().Result;
                var result = response.Content.ReadAsStringAsync().Result;

                data = result;
            }
        }
        catch (Exception e)
        {
            data = e.Message;
        }

        return data;
    }

    public string EnviarCorreos(string mensaje)
    {
        EmailRequest request = new EmailRequest(mensaje);
        var requestContent = JsonContent.Create(request);
        string data = "";
        try
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();

            var response = client.PostAsync("https://soa-p2-bellako-production.up.railway.app/Email", requestContent).Result;

            if (response.IsSuccessStatusCode)
            {
                // response.Content.ReadAsStringAsync().Result;
                var result = response.Content.ReadAsStringAsync().Result;

                data = result;
            }
        }
        catch (Exception e)
        {
            data = e.Message;
        }

        return data;
    }


}
