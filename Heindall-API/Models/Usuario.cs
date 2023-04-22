using Microsoft.EntityFrameworkCore.Metadata;
using System.Text.Json.Serialization;

namespace Heindall_API.Models;

public class Usuario : BaseEntity
{
	public string Cnpj { get; set; }
	public string Nivel { get; set; }
	public string NomeEmpresa { get; set; }
	public string HostBd { get; set; }
	public string UserBd { get; set; }
	public string SenhaBd { get; set; }
	public string PortaBd { get; set; }
	public string SchemaBd { get; set; }

	[JsonIgnore]
	public IEnumerable<IntegradorDoUsuario> IntegradoresDoUsuario { get; private set; }

}
