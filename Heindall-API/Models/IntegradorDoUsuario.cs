namespace Heindall_API.Models;

public class IntegradorDoUsuario : BaseEntity
{
	public int UsuarioId { get; set; }
	public int IntegradorId { get; set; }
	public Usuario Usuario { get; set; }
	public Integrador Integrador { get; set; }
}
