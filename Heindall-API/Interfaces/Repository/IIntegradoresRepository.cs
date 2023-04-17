using Heindall_API.Models;

namespace Heindall_API.Interfaces.Repository;

public interface IIntegradoresRepository
{
    Task<IEnumerable<Integrador>> Obter();

    Task<Integrador> ObterPorId(long id);

    Task Criar(Integrador integrador);

    Task Atualizar(long id, Integrador integrador);

    Task Remover(long id);
}
