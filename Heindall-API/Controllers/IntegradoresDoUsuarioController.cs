using AutoMapper;
using Heindall_API.Interfaces.Repository;
using Heindall_API.Models;
using Heindall_API.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Heindall_API.Controllers;

[ApiController]
[Route("[controller]")]
public class IntegradoresDoUsuarioController : ControllerBase
{
	private readonly IIntegradoresDoUsuarioRepository _repositoryIntegradoresDoUsuario;
	private readonly IIntegradoresRepository _repositoryIntegradores;
	private readonly IRepository<Usuario> _repositoryUsuario;
	private IMapper _mapper;

	public IntegradoresDoUsuarioController(IIntegradoresDoUsuarioRepository repositoryIntegradoresDoUsuario, 
		IIntegradoresRepository repositoryIntegradores, IRepository<Usuario> repositoryUsuario, IMapper mapper)
	{
		_repositoryIntegradoresDoUsuario = repositoryIntegradoresDoUsuario;
		_repositoryIntegradores = repositoryIntegradores;
		_repositoryUsuario = repositoryUsuario;
		_mapper = mapper;
	}

	#region GET

	[HttpGet]
	public async Task<IActionResult> ObterTodosOsIntegradoresDoUsuario()
	{
		try
		{
			var result = await _repositoryIntegradoresDoUsuario.Obter();
			return Ok(result);
		}
		catch (Exception ex)
		{
			return BadRequest(ex.Message);
		}
	}

	[HttpGet("obterPorId")]
	public async Task<IActionResult> ObterIntegradorDoUsuarioPorId([FromQuery] long id)
	{
		try
		{
			var result = await _repositoryIntegradoresDoUsuario.ObterPorId(id);
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
	public async Task<IActionResult> CriarIntegradorDoUsuario([FromBody] IntegradorDoUsuarioDto dto)
	{
		try
		{
			var usuario = await _repositoryUsuario.ObterPorId(dto.UsuarioId);

			if (usuario is null)
				return NotFound($"Usuario com o ID {dto.UsuarioId} não encontrado");

			var integrador = await _repositoryIntegradores.ObterPorId(dto.IntegradorId);

			if (integrador is null)
				return NotFound($"Integrador com o ID {dto.IntegradorId} não encontrado");

			var integradorDoUsuario = _mapper.Map<IntegradorDoUsuario>(dto);

			integradorDoUsuario.AdicionarUsuarioId(usuario.Id.Value);
			integradorDoUsuario.AdicionarIntegradorId(integrador.Id.Value);

			await _repositoryIntegradoresDoUsuario.Criar(integradorDoUsuario);

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
	public async Task<IActionResult> AtualizarIntegradorDoUsuario([FromQuery] long  id, [FromBody] IntegradorDoUsuarioDto dto)
	{
		try
		{
			if (id != dto.Id)
				return BadRequest($"IDs divergentes ID Query:{id} / ID Body:{dto.Id}");

			var integradorDoUsuarioExistente = await _repositoryIntegradoresDoUsuario.ObterPorId(id);

			if (integradorDoUsuarioExistente is null)
				return NotFound($"Integrador do usuario com o ID {id} não encontrado");


			var integradorDoUsuario = _mapper.Map<IntegradorDoUsuario>(dto);

			integradorDoUsuario.AdicionarUsuarioId(integradorDoUsuarioExistente.UsuarioId);
			integradorDoUsuario.AdicionarIntegradorId(integradorDoUsuarioExistente.IntegradorId);

			await _repositoryIntegradoresDoUsuario.Atualizar(id, integradorDoUsuario);
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
	public async Task<IActionResult> DeletarIntegradorDoUsuario([FromQuery] long id)
	{
		try
		{
			await _repositoryIntegradoresDoUsuario.Remover(id);
			return NoContent();
		}
		catch (Exception ex)
		{
			return BadRequest(ex.Message);
		}
	}

	#endregion DELETE
}
