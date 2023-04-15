using Heindall_API.Interfaces;
using Heindall_API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Heindall_API.Controllers;

[ApiController]
[Route("[controller]")]
public class GruposController : ControllerBase
{
	private readonly IRepository<Grupo> _repository;

	public GruposController(IRepository<Grupo> repository)
	{
		_repository = repository;
	}

	#region GET

	[HttpGet]
	public async Task<IActionResult> ObterTodosOsGrupos()
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
	public async Task<IActionResult>  ObterGrupoPorId([FromQuery] long id)
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
	public async Task<IActionResult>  CriarGrupo([FromBody] Grupo grupo)
	{
		try
		{
			await _repository.Criar(grupo);
			return Created("Grupo criado", grupo);
		}
		catch (Exception ex)
		{
			return BadRequest(ex.Message);
		}
	}

	#endregion POST

	#region PUT

	[HttpPut]
	public async Task<IActionResult> AtualizarGrupo([FromQuery] long id, [FromBody] Grupo grupo)
	{
		try
		{
			await _repository.Atualizar(id, grupo);
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
	public async Task<IActionResult>  DeletarGrupo([FromQuery] long id)
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
