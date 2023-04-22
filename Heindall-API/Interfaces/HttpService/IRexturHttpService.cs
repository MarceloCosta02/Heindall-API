using Heindall_API.Models.Responses;

namespace Heindall_API.Interfaces.Services;

public interface IRexturHttpService
{
    Task<IEnumerable<TicketsResponse>> ObterTickets(string requestDate);
}
