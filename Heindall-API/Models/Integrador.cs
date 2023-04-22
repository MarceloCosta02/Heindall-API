using System.Text.Json.Serialization;

namespace Heindall_API.Models;

public class Integrador : BaseEntity
{
	public string IntegradorNome { get; set; }
	public string IntegradorGrupo { get; set; }
	public string IntegradorEndpoint { get; set; }
	public string IntegradorPublicKey { get; set; }
	public string IntegradorPrivateKey { get; set; }
	public long GrupoId { get; set; } // nova chave estrangeira


	public Grupo Grupo { get; private set; }

	[JsonIgnore]
	public IEnumerable<IntegradorDoUsuario> UsuariosDoIntegrador { get; private set; }


	public void AdicionarGrupoId(long id) => GrupoId = id;
}
