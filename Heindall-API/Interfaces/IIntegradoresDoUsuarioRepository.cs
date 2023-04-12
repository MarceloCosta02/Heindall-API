using Heindall_API.Models;

namespace Heindall_API.Interfaces;

public interface IIntegradoresDoUsuarioRepository
{
    Task<IEnumerable<IntegradorDoUsuario>> Obter();

    Task<IntegradorDoUsuario> ObterPorId(int id);

    Task Criar(IntegradorDoUsuario integradorDoUsuario);

    Task Atualizar(int id, IntegradorDoUsuario integradorDoUsuario);

    Task Remover(int id);
}
