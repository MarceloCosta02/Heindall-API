using AutoMapper;
using Heindall_API.Enums;
using Heindall_API.Factory;
using Heindall_API.Interfaces.Repository;
using Heindall_API.Interfaces.Service;
using Heindall_API.Models.Responses;
using Heindall_API.Models.Rextur;
using Heindall_API.Repository;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Core.Types;

namespace Heindall_API.Services;

public class ImportacaoService : IImportacaoService
{
    private readonly IIntegradoresDoUsuarioRepository _integradoresDoUsuarioRepo;
    private readonly IConfiguration _configuration;
    private readonly IMapper _mapper;

    public ImportacaoService(IIntegradoresDoUsuarioRepository integradoresDoUsuarioRepo,
        IConfiguration configuration,
        IMapper mapper)
    {
        _integradoresDoUsuarioRepo = integradoresDoUsuarioRepo;
        _configuration = configuration;
        _mapper = mapper;
    }

    public async Task ImportarParaBasesCadastradas(IEnumerable<TicketsResponse> ticketsResponse)
    {
        // Buscar na tabela integrador de usuario os cadastrados 
        var integradoresDoUsuario = await _integradoresDoUsuarioRepo.Obter();

        // Filtra os integradores do usuário para obter apenas o integrador da Rextur --> RexturAdvance
        var integradoresUsuarioComRextur = integradoresDoUsuario
            .Where(x => x.Integrador.IntegradorNome.Equals(nameof(NomeIntegradores.RexturAdvance)));

        // Pega somente a lista de usuários
        var listaUsuariosComIntegradorRextur = integradoresUsuarioComRextur.Select(u => u.Usuario);

        // Cria uma instância da fábrica de contexto de banco de dados
        var contextFactory = new DatabaseContextFactory();

        // Realiza o loop de usuários
        foreach (var usuario in listaUsuariosComIntegradorRextur)
        {
            // Cria a connection string com base nos dados de usuário
            string novaConnectionString = CriarConnectionString(usuario.SchemaBd, usuario.UserBd, usuario.SenhaBd);

            // Cria uma instância do contexto de banco de dados para o usuário atual
            using var context = contextFactory.CreateRexturContext(novaConnectionString);
            
            var rexturRepository = new RexturRepository(context);

            // Obtem os numeros de ticket ja existentes na base
            var numerosDeTicket = await rexturRepository.ObterNumerosDeTicketExistentes();

            // Validação para ver se o ticketsResponse não possui os numerosDeTicket já existentes no banco
            var ticketsNaoExistentes = ticketsResponse.Where(t => !numerosDeTicket.Contains(t.TktNum));

            if (ticketsNaoExistentes.Any() || numerosDeTicket.Count() == 0)
            {
                var tickets = _mapper.Map<IEnumerable<Ticket>>(ticketsResponse);

                await rexturRepository.InserirVariosTicket(tickets);
            }
        }
    }

    private string CriarConnectionString(string newDatabaseName, string newUserName, string newPassword)
    {
        string template = _configuration.GetConnectionString("CustomConnectionString");

        return template
            .Replace("{catalog}", newDatabaseName)
            .Replace("{uid}", newUserName)
            .Replace("{pwd}", newPassword);
    }
}
