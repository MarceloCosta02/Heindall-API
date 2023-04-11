using Heindall_API.Models;

namespace Heindall_API.Interfaces;

public interface IRepository<T> where T : BaseEntity
{
	Task<IEnumerable<T>> Obter();

	Task<T> ObterPorId(int id);

	Task Criar(T item);

	Task Atualizar(int id, T item);

	Task Remover(int id);
}
