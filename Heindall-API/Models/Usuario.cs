using Microsoft.EntityFrameworkCore.Metadata;

namespace Heindall_API.Models;

public class Usuario : BaseEntity
{
	public int UsuarioId { get; set; }
	public string UsuarioName { get; set; }
	public string UsuarioIDAgencia { get; set; }
	public int UsuarioCNPJ { get; set; }
	public string UsuarioNivel { get; set; }
	public string UsuarioBancoDestino { get; set; }
	public virtual ICollection<Integrador> Integradores { get; set; }
}
