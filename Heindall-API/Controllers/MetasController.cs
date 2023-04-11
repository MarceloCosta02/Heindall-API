using Heindall_API.Interfaces;
using Heindall_API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Heindall_API.Controllers;

[ApiController]
[Route("[controller]")]
public class MetasController : ControllerBase
{
	private readonly IRepository<Meta> _repository;

	public MetasController(IRepository<Meta> repository)
	{
		_repository = repository;
	}

	#region GET

	[HttpGet]
	public async Task<IActionResult> ObterTodasAsMetas()
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
	public async Task<IActionResult> ObterMetaPorId([FromQuery] int id)
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
	public async Task<IActionResult> CriarMeta([FromBody] Meta meta)
	{
		try
		{
			await _repository.Criar(meta);
			return Created("Meta criado", meta);
		}
		catch (Exception ex)
		{
			return BadRequest(ex.Message);
		}
	}

	#endregion POST

	#region PUT

	[HttpPut]
	public async Task<IActionResult> AtualizarMeta([FromQuery] int id, [FromBody] Meta meta)
	{
		try
		{
			await _repository.Atualizar(id, meta);
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
	public async Task<IActionResult> DeletarMeta([FromQuery] int id)
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
