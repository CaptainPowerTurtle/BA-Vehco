using AutoMapper;
using Vecho.Consumer.Model.General;
using Vehco.Repository.Models.General;

namespace Vehco.Repository.Mappings;

public class GeneralMappings : Profile
{
    public GeneralMappings()
    {
        CreateMap<VehicleIdDTO, Vehicle>()
            .ForMember(dest => dest.VehicleId, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.ExternalId, opt => opt.MapFrom(src => src.ExternalId))
            .ForMember(dest => dest.LicensePlate, opt => opt.MapFrom(src => src.LicensePlateNumber))
            .ForMember(dest => dest.RoadBoxId, opt => opt.MapFrom(src => src.RoadBoxId));
        CreateMap<DriverDTO, Driver>()
            .ForMember(dest => dest.DriverId, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.Username, opt => opt.MapFrom(src => src.UserName));
        CreateMap<PositionDTO, Position>()
            .ForMember(dest => dest.Latitude, opt => opt.MapFrom(src => src.Latitude))
            .ForMember(dest => dest.Longitude, opt => opt.MapFrom(src => src.Longitude));
    }
}