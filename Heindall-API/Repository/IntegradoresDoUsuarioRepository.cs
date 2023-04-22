using Heindall_API.Context;
using Heindall_API.Interfaces.Repository;
using Heindall_API.Models;
using Microsoft.EntityFrameworkCore;

namespace Heindall_API.Repository;

public class IntegradoresDoUsuarioRepository : IIntegradoresDoUsuarioRepository
{
    private readonly MySQLContext _context;

    public IntegradoresDoUsuarioRepository(MySQLContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<IntegradorDoUsuario>> Obter()
    {
        var integradoresdoUsuario = _context.IntegradoresdoUsuario
            .Include(i => i.Integrador).ThenInclude(g => g.Grupo)
            .Include(i => i.Usuario)
            .AsNoTracking();

        return await integradoresdoUsuario.ToListAsync();
    }

    public async Task<IntegradorDoUsuario> ObterPorId(long id)
    {
        var integradorDoUsuario = await _context.IntegradoresdoUsuario
            .Include(i => i.Integrador).ThenInclude(g => g.Grupo)
            .Include(i => i.Usuario)
            .AsNoTracking()
            .FirstOrDefaultAsync(m => m.Id == id);

        return integradorDoUsuario;
    }

    public async Task Criar(IntegradorDoUsuario integradordoUsuario)
    {
        _context.Add(integradordoUsuario);
        await _context.SaveChangesAsync();
    }

    public async Task Atualizar(long id, IntegradorDoUsuario integradordoUsuario)
    {
        _context.Update(integradordoUsuario);
        await _context.SaveChangesAsync();
    }

    public async Task Remover(long id)
    {
        var integradordoUsuario = await ObterPorId(id);

        if (integradordoUsuario is null)
            throw new Exception($"Integrador do usuário com o id {id} a ser removido não existe");

        _context.IntegradoresdoUsuario.Remove(integradordoUsuario);
        await _context.SaveChangesAsync();
    }
}