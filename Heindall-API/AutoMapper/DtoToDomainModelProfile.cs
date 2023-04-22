using AutoMapper;
using Heindall_API.Models;
using Heindall_API.Models.DTOs;

namespace Rextur.Domain.AutoMapper;

public class DtoToDomainModelProfile : Profile
{
	public DtoToDomainModelProfile()
	{
		CreateMap<IntegradorDto, Integrador>()
			.ReverseMap();

		CreateMap<IntegradorDoUsuarioDto, IntegradorDoUsuario>()
			.ReverseMap();
	}
}
