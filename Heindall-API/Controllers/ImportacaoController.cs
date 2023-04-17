using Heindall_API.Interfaces.Repository;
using Heindall_API.Interfaces.Services;
using Heindall_API.Models;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace Heindall_API.Controllers;

[ApiController]
[Route("[controller]")]
public class ImportacaoController : ControllerBase
{
	private readonly IRexturService _service;

	public ImportacaoController(IRexturService service)
	{
		_service = service;
	}

	#region GET

	[HttpPost("rextur")]
	public async Task<IActionResult> ImportacaoRextur([FromBody] string requestDate)
	{
		if (string.IsNullOrEmpty(requestDate))
			return BadRequest("Favor informar uma data de requisição");

		bool isValid = DateTime.TryParseExact(requestDate, "yyyyMMdd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date);

		if (isValid == false)
			return BadRequest($"Formato incorreto, foi recebida a data: {requestDate} - Formato esperado: yyyyMMdd");

		try
		{
			var result = await _service.ObterTickets(requestDate);
			return Ok(result);
		}
		catch (Exception ex)
		{
			return BadRequest(ex.Message);
		}
	}

	#endregion GET
}
