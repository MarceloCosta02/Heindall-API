using Heindall_API.Models;

namespace Heindall_API.Interfaces.Repository;

public interface IIntegradoresDoUsuarioRepository
{
    Task<IEnumerable<IntegradorDoUsuario>> Obter();

    Task<IntegradorDoUsuario> ObterPorId(long id);

    Task Criar(IntegradorDoUsuario integradorDoUsuario);

    Task Atualizar(long id, IntegradorDoUsuario integradorDoUsuario);

    Task Remover(long id);
}
