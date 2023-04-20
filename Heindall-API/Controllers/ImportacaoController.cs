using Heindall_API.Interfaces.Repository;
using Heindall_API.Interfaces.Service;
using Heindall_API.Interfaces.Services;
using Heindall_API.Models;
using Heindall_API.Models.Requests;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace Heindall_API.Controllers;

[ApiController]
[Route("[controller]")]
public class ImportacaoController : ControllerBase
{
	private readonly IRexturHttpService _httpService;
	private readonly IImportacaoService _service;

	public ImportacaoController(IRexturHttpService httpService, IImportacaoService service)
	{
		_httpService = httpService;
		_service = service;
	}

	#region GET

	[HttpPost("rextur")]
	public async Task<IActionResult> ImportacaoRextur([FromBody] ImportacaoRexturRequest request)
	{
		if (string.IsNullOrEmpty(request.RequestDate))
			return BadRequest("Favor informar uma data de requisição");

		bool isValid = DateTime.TryParseExact(request.RequestDate, "yyyyMMdd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date);

		if (isValid == false)
			return BadRequest($"Formato incorreto, foi recebida a data: {request.RequestDate} - Formato esperado: yyyyMMdd");

		try
		{
			var result = await _httpService.ObterTickets("20230416");

			await _service.ImportarParaBasesCadastradas(result);

			return Ok(result);
		}
		catch (Exception ex)
		{
			return BadRequest(ex.Message);
		}
	}

	#endregion GET
}
