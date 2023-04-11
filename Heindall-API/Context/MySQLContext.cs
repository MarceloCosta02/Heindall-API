using Heindall_API.Models;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;

namespace Heindall_API.Context;

public class MySQLContext : DbContext
{
	public MySQLContext(DbContextOptions<MySQLContext> options)
		: base(options) => Database.EnsureCreated();

	public DbSet<Grupo> Grupos { get; set; }
	public DbSet<Integrador> Integradores { get; set; }
	public DbSet<Usuario> Usuarios { get; set; }
	public DbSet<IntegradorDoUsuario> IntegradoresdoUsuario { get; set; }
	public DbSet<Meta> Metas { get; set; }
}
