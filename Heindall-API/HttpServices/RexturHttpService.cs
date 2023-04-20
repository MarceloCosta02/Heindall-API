using Heindall_API.Interfaces.Services;
using Heindall_API.Models.Responses;
using Heindall_API.Settings;
using Newtonsoft.Json;

namespace Heindall_API.HttpServices;

public class RexturHttpService : IRexturHttpService
{
    protected HttpClient _client;
    private readonly RexturServerlessSettings _settings;

    public RexturHttpService(HttpClient client, RexturServerlessSettings settings)
    {
        _client = client;
        _settings = settings;
    }

    public async Task<IEnumerable<TicketsResponse>> ObterTickets(string requestDate)
    {
        string url = $"{_settings.Url}?requestDate={requestDate}&code={_settings.Code}";

        var response = await _client.GetAsync(url);

        if (!response.IsSuccessStatusCode)
            throw new HttpRequestException($"Erro ao chamar API: {url} - ");

        var content = await response.Content.ReadAsStringAsync();
        var tickets = JsonConvert.DeserializeObject<IEnumerable<TicketsResponse>>(content);

        return tickets;
    }
}
