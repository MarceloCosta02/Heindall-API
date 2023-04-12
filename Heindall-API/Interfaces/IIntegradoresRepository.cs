using Heindall_API.Models;

namespace Heindall_API.Interfaces;

public interface IIntegradoresRepository
{
    Task<IEnumerable<Integrador>> Obter();

    Task<Integrador> ObterPorId(int id);

    Task Criar(Integrador integrador);

    Task Atualizar(int id, Integrador integrador);

    Task Remover(int id);
}
