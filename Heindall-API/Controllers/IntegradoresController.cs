using AutoMapper;
using Heindall_API.Interfaces;
using Heindall_API.Models;
using Heindall_API.Models.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace Heindall_API.Controllers;

[ApiController]
[Route("[controller]")]
public class IntegradoresController : ControllerBase
{
	private readonly IIntegradoresRepository _repositoryIntegradores;
	private readonly IRepository<Grupo> _repositoryGrupo;
	private IMapper _mapper;

	public IntegradoresController(IIntegradoresRepository repository, IRepository<Grupo> repositoryGrupo, IMapper mapper)
	{
		_repositoryIntegradores = repository;
		_repositoryGrupo = repositoryGrupo;

		_mapper = mapper;
	}

	#region GET

	[HttpGet]
	public async Task<IActionResult> ObterTodosOsIntegradores()
	{
		try
		{
			var result = await _repositoryIntegradores.Obter();
			return Ok(result);
		}
		catch (Exception ex)
		{
			return BadRequest(ex.Message);
		}
	}

	[HttpGet("obterPorId")]
	public async Task<IActionResult> ObterIntegradorPorId([FromQuery] long id)
	{
		try
		{
			var result = await _repositoryIntegradores.ObterPorId(id);
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
	public async Task<IActionResult> CriarIntegrador([FromBody] IntegradorDto dto)
	{
		try
		{
			var grupo = await _repositoryGrupo.ObterPorId(dto.GrupoId);

			if (grupo is null)
				return NotFound($"Grupo com o ID {dto.GrupoId} não encontrado");

			var integrador = _mapper.Map<Integrador>(dto);
			integrador.AdicionarGrupoId(grupo.Id.Value);

            await _repositoryIntegradores.Criar(integrador);

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
	public async Task<IActionResult> AtualizarIntegrador([FromQuery] long id, [FromQuery] bool alterarGrupo, [FromBody] IntegradorDto dto)
	{
		try
        {
            if (id != dto.Id)
                return BadRequest($"IDs divergentes ID Query:{id} / ID Body:{dto.Id}");

            var integradorExistente = await _repositoryIntegradores.ObterPorId(id);

            if (integradorExistente is null)
                return NotFound($"Integrador com o ID {id} não encontrado");	

            var integrador = _mapper.Map<Integrador>(dto);

			if (alterarGrupo)
			{
                var grupo = await _repositoryGrupo.ObterPorId(dto.GrupoId);

                if (grupo is null)
                    return NotFound($"Grupo com o ID {dto.GrupoId} não encontrado");

                integrador.AdicionarGrupoId(dto.GrupoId);
            }

            else
                integrador.AdicionarGrupoId(integradorExistente.GrupoId);

            await _repositoryIntegradores.Atualizar(id, integrador);
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
	public async Task<IActionResult> DeletarIntegrador([FromQuery] long id)
	{
		try
		{
			await _repositoryIntegradores.Remover(id);
			return NoContent();
		}
		catch (Exception ex)
		{
			return BadRequest(ex.Message);
		}
	}

	#endregion DELETE
}
