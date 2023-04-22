namespace Heindall_API.Models;

public class IntegradorDoUsuarioDto : BaseEntity
{
	public int UsuarioIdAgencia { get; set; }
	public string LoginIntegradorUsuario { get; set; }
	public string SenhaIntegradorUsuario { get; set; }
	public int PortaIntegradorUsuario { get; set; }
	public string PublicKeyIntegradorUsuario { get; set; }
	public string PrivateKeyIntegradorUsuario { get; set; }

	public int UsuarioId { get; set; }
	public int IntegradorId { get; set; }

}
