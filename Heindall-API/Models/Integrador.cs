namespace Heindall_API.Models;

public class Integrador : BaseEntity
{
	public string IntegradorNome { get; set; }
	public string IntegradorGrupo { get; set; }
	public int IntegradorEndpoint { get; set; }
	public string IntegradorPublicKey { get; set; }
	public string IntegradorPrivateKey { get; set; }

	public Grupo Grupo { get; set; }

    public IEnumerable<IntegradorDoUsuario> UsuariosDoIntegrador { get; private set; }

}
