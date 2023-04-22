using Heindall_API.Context;
using Heindall_API.Interfaces.Repository;
using Heindall_API.Models;
using Microsoft.EntityFrameworkCore;

namespace Heindall_API.Repository;

public class Repository<T> : IRepository<T> where T : BaseEntity
{
	private readonly MySQLContext _context;
	private DbSet<T> dataset;

	public Repository(MySQLContext context)
	{
		_context = context;
		dataset = _context.Set<T>();
	}

	public async Task<IEnumerable<T>> Obter() => await dataset.AsNoTracking().ToListAsync();

	public async Task<T> ObterPorId(long id) => await dataset.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);

	public async Task Criar(T item)
	{
		item.TornarIdDefault();

		await dataset.AddAsync(item);
		await _context.SaveChangesAsync();
	}

	public async Task Atualizar(long id, T item)
	{
		var itemEncontrado = await ObterPorId(id);

		if (itemEncontrado is null)
			throw new DbUpdateConcurrencyException($"Item com o id {id} a ser atualizado não existe");

		dataset.Update(item);
		await _context.SaveChangesAsync();
	}

	public async Task Remover(long id)
	{
		var itemEncontrado = await ObterPorId(id);

		if (itemEncontrado is null)
			throw new Exception($"Item com o id {id} a ser removido não existe");

		dataset.Remove(itemEncontrado);
		await _context.SaveChangesAsync();
	}
}


