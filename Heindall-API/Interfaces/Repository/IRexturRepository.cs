using Heindall_API.Models.Rextur;
using System.Net.Sockets;

namespace Heindall_API.Interfaces.Repository;

public interface IRexturRepository
{
    Task InserirTicket(Ticket ticket);

    Task InserirVariosTicket(IEnumerable<Ticket> tickets);

    Task<IEnumerable<Ticket>> ObterTickets();

    Task<IEnumerable<string>> ObterNumerosDeTicketExistentes();
}
