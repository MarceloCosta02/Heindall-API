using Heindall_API.Context;
using Heindall_API.Interfaces.Repository;
using Heindall_API.Models.Rextur;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Heindall_API.Repository;

public class RexturRepository : IRexturRepository
{
    private readonly RexturContext _dbContext;

    public RexturRepository(RexturContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task InserirTicket(Ticket ticket)
    {
        await _dbContext.Tickets.AddAsync(ticket);

        await _dbContext.SaveChangesAsync();
    }

    public async Task InserirVariosTicket(IEnumerable<Ticket> tickets)
    {
        await _dbContext.Tickets.AddRangeAsync(tickets);

        await _dbContext.SaveChangesAsync();
    }

    public async Task<IEnumerable<Ticket>> ObterTickets()
    {
        var tickets = await _dbContext.Tickets
            .Include(t => t.Itineraries)
            .Include(t => t.Passengers)
            .Include(t => t.Onibus)
            .Include(t => t.Carros)
            .Include(t => t.ManagementFields)
            .Include(t => t.Hoteis)
            .ToListAsync();

        return tickets;
    }

    public async Task<IEnumerable<string>> ObterNumerosDeTicketExistentes()
    {
        var tktNums = await _dbContext.Tickets.Select(t => t.TktNum).AsNoTracking().ToListAsync();
        return tktNums;
    }
}
