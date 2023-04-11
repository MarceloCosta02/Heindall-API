using Heindall_API.Interfaces;
using Heindall_API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Heindall_API.Controllers;

[ApiController]
[Route("[controller]")]
public class IntegradoresController : ControllerBase
{
	private readonly IRepository<Integrador> _repository;

	public IntegradoresController(IRepository<Integrador> repository)
	{
		_repository = repository;
	}

	#region GET

	[HttpGet]
	public async Task<IActionResult> ObterTodosOsIntegradores()
	{
		try
		{
			var result = await _repository.Obter();
			return Ok(result);
		}
		catch (Exception ex)
		{
			return BadRequest(ex.Message);
		}
	}

	[HttpGet("obterPorId")]
	public async Task<IActionResult> ObterIntegradorPorId([FromQuery] int id)
	{
		try
		{
			var result = await _repository.ObterPorId(id);
			return Ok(result);
		}
		catch (Exception ex)
		{
			return BadRequest(ex.Message);
		}
	}

	#endregion GET

	#region POST

	[HttpPost]
	public async Task<IActionResult> CriarIntegrador([FromBody] Integrador integrador)
	{
		try
		{
			await _repository.Criar(integrador);
			return Created("Integrador criado", integrador);
		}
		catch (Exception ex)
		{
			return BadRequest(ex.Message);
		}
	}

	#endregion POST

	#region PUT

	[HttpPut]
	public async Task<IActionResult> AtualizarIntegrador([FromQuery] int id, [FromBody] Integrador integrador)
	{
		try
		{
			await _repository.Atualizar(id, integrador);
			return NoContent();
		}
		catch (Exception ex)
		{
			return BadRequest(ex.Message);
		}
	}

	#endregion PUT

	#region DELETE

	[HttpDelete]
	public async Task<IActionResult> DeletarIntegrador([FromQuery] int id)
	{
		try
		{
			await _repository.Remover(id);
			return NoContent();
		}
		catch (Exception ex)
		{
			return BadRequest(ex.Message);
		}
	}

	#endregion DELETE
}
