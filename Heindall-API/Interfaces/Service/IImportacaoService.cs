using Heindall_API.Models.Responses;

namespace Heindall_API.Interfaces.Service;

public interface IImportacaoService
{
    Task ImportarParaBasesCadastradas(IEnumerable<TicketsResponse> tickets);
}