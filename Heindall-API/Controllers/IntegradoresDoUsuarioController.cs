using Heindall_API.Interfaces;
using Heindall_API.Models;
using Heindall_API.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Heindall_API.Controllers;

[ApiController]
[Route("[controller]")]
public class IntegradoresDoUsuarioController : ControllerBase
{
	private readonly IIntegradoresDoUsuarioRepository _repository;

	public IntegradoresDoUsuarioController(IIntegradoresDoUsuarioRepository repository)
	{
		_repository = repository;
	}

	#region GET

	[HttpGet]
	public async Task<IActionResult> ObterTodosOsIntegradoresDoUsuario()
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
	public async Task<IActionResult> ObterIntegradorDoUsuarioPorId([FromQuery] int id)
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
	public async Task<IActionResult> CriarIntegradorDoUsuario([FromBody] IntegradorDoUsuario integradorDoUsuario)
	{
		try
		{
			await _repository.Criar(integradorDoUsuario);
			return Created("Integrador do usuário criado", integradorDoUsuario);
		}
		catch (Exception ex)
		{
			return BadRequest(ex.Message);
		}
	}

	#endregion POST

	#region PUT

	[HttpPut]
	public async Task<IActionResult> AtualizarIntegradorDoUsuario([FromQuery] int id, [FromBody] IntegradorDoUsuario integradorDoUsuario)
	{
		try
		{
			await _repository.Atualizar(id, integradorDoUsuario);
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
	public async Task<IActionResult> DeletarIntegradorDoUsuario([FromQuery] int id)
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
