using Heindall_API.Models;

namespace Heindall_API.Interfaces;

public interface IRepository<T> where T : BaseEntity
{
	Task<IEnumerable<T>> Obter();

	Task<T> ObterPorId(long id);

	Task Criar(T item);

	Task Atualizar(long id, T item);

	Task Remover(long id);
}
