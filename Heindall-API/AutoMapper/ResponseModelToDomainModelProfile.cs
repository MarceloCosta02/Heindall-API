using AutoMapper;
using Heindall_API.Models.Responses;
using Heindall_API.Models.Rextur;

namespace Heindall_API.AutoMapper;

public class ResponseModelToDomainModelProfile : Profile
{
    public ResponseModelToDomainModelProfile()
    {
        CreateMap<TicketsResponse, Ticket>()
            .ForPath(d => d.FormsOfPayment, o => o.MapFrom(s => string.Concat(s.FormsOfPayment)))
            .ReverseMap();

        CreateMap<ItineraryListResponse, Itinerary>()
            .ReverseMap();

        CreateMap<PassengerListResponse, Passenger>()
            .ReverseMap();

        CreateMap<OnibusResponse, Onibus>()
            .ReverseMap();

        CreateMap<ManagementFieldListResponse, ManagementField>()
            .ReverseMap();

        CreateMap<HotelList, Hotel>()
            .ReverseMap();

        CreateMap<CarroResponse, Carro>()
            .ReverseMap();
    }
}
