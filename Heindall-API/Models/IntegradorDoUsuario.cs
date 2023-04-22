namespace Heindall_API.Models;

public class IntegradorDoUsuario : BaseEntity
{
	public int UsuarioIdAgencia { get; set; }
	public string LoginIntegradorUsuario { get; set; }
	public string SenhaIntegradorUsuario { get; set; }
	public int PortaIntegradorUsuario { get; set; }
	public string PublicKeyIntegradorUsuario { get; set; }
	public string PrivateKeyIntegradorUsuario { get; set; }
	public long UsuarioId { get; set; }
	public long IntegradorId { get; set; }

	public Usuario Usuario { get; private set; }

	public Integrador Integrador { get; private set; }

	public void AdicionarUsuarioId(long id) => UsuarioId = id;

	public void AdicionarIntegradorId(long id) => IntegradorId = id;
}
