using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
[ServiceContract]
public interface IService
{

	[OperationContract]
	string GetData(int value);

	//GET
	[OperationContract]
	string GetDataPersonabyId(int id);
	[OperationContract]
	string ObtenerEmpleados();
	[OperationContract]
	string ObtenerEmpleadosActivos();
	[OperationContract]
	string ObtenerActivos();

	//POST
	[OperationContract]
	string RegistrarActivo(string Nombre, string Descripcion, bool Estatus);
	[OperationContract]
	string RegistrarEmpleado(int numeroEmpleado, bool estatus,
		DateTime fechaIngreso, string nombre, string apellidos,
		string curp, string correo, DateTime FechaNacimiento);

	[OperationContract]
	string RegistrarActivoEmpledao(int identificadorEmpleado, int identificadoActivo, DateTime fechaAsignacion, DateTime fechaLiberacion, DateTime fechaEntrega);
    // TODO: agregue aquí sus operaciones de servicio
}

// Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
[DataContract]
public class CompositeType
{
	bool boolValue = true;
	string stringValue = "Hello ";

	[DataMember]
	public bool BoolValue
	{
		get { return boolValue; }
		set { boolValue = value; }
	}

	[DataMember]
	public string StringValue
	{
		get { return stringValue; }
		set { stringValue = value; }
	}
}
