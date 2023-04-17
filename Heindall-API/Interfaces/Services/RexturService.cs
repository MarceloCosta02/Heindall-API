using Heindall_API.Models.Responses;

namespace Heindall_API.Interfaces.Services;

public interface IRexturService
{
    Task<IEnumerable<TicketsResponse>> ObterTickets(string requestDate);
}
