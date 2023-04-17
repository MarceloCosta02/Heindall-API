using Heindall_API.Context;
using Heindall_API.Interfaces.Repository;
using Heindall_API.Models;
using Microsoft.EntityFrameworkCore;

namespace Heindall_API.Repository;

public class IntegradoresRepository : IIntegradoresRepository
{
    private readonly MySQLContext _context;

    public IntegradoresRepository(MySQLContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Integrador>> Obter()
    {
        var integradores = _context.Integradores.Include(i => i.Grupo).AsNoTracking();
        return await integradores.ToListAsync();
    }

    public async Task<Integrador> ObterPorId(long id)
    {
        var integrador = await _context.Integradores
                    .Include(i => i.Grupo)
                    .AsNoTracking()
                    .FirstOrDefaultAsync(m => m.Id == id);

        return integrador;
    }

    public async Task Criar(Integrador integrador)
    {
        _context.Add(integrador);
        await _context.SaveChangesAsync();
    }

    public async Task Atualizar(long id, Integrador integrador)
    {
        _context.Update(integrador);
        await _context.SaveChangesAsync();
    }

    public async Task Remover(long id)
    {
        var integrador = await ObterPorId(id);

        if (integrador is null)
            throw new Exception($"Integrador com o id {id} a ser removido não existe");

        _context.Integradores.Remove(integrador);
        await _context.SaveChangesAsync();
    }
}