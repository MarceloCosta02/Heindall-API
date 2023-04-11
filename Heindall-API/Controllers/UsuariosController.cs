using Heindall_API.Interfaces;
using Heindall_API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Heindall_API.Controllers;

[ApiController]
[Route("[controller]")]
public class UsuariosController : ControllerBase
{
	private readonly IRepository<Usuario> _repository;

	public UsuariosController(IRepository<Usuario> repository)
	{
		_repository = repository;
	}

	#region GET

	[HttpGet]
	public async Task<IActionResult> ObterTodosOsUsuarios()
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
	public async Task<IActionResult> ObterUsuarioPorId([FromQuery] int id)
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
	public async Task<IActionResult> CriarUsuario([FromBody] Usuario usuario)
	{
		try
		{
			await _repository.Criar(usuario);
			return Created("Usuario criado", usuario);
		}
		catch (Exception ex)
		{
			return BadRequest(ex.Message);
		}
	}

	#endregion POST

	#region PUT

	[HttpPut]
	public async Task<IActionResult> AtualizarUsuario([FromQuery] int id, [FromBody] Usuario usuario)
	{
		try
		{
			await _repository.Atualizar(id, usuario);
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
	public async Task<IActionResult> DeletarUsuario([FromQuery] int id)
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
