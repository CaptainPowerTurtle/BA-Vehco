using AutoMapper;
using Vehco.Domain.Models.DRTEvent;
using Vehco.Repository.Models.DRTEvent;

namespace Vehco.Repository.Mappings;

public class DRTEventProfile : Profile
{
    public DRTEventProfile()
    {
        CreateMap<TachographEventDTO, TachographEvent>()
            .ForMember(dest => dest.DriverId, opt => opt.MapFrom(src => src.User.Id))
            .ForMember(dest => dest.TachographEventType, opt => opt.MapFrom(src => src.TachographEventType))
            .ForMember(dest => dest.Mileage, opt => opt.MapFrom(src => src.Mileage))
            .ForMember(dest => dest.Timestamp, opt => opt.MapFrom(src => src.Timestamp))
            .ForMember(dest => dest.VehicleId, opt => opt.MapFrom(src => src.Vehicle.Id));
        CreateMap<TachographActivityPeriodDTO, TachographActivityPeriod>()
            .ForMember(dest => dest.DriverId, opt => opt.MapFrom(src => src.User.Id))
            .ForMember(dest => dest.EndMileage, opt => opt.MapFrom(src => src.EndMileage))
            .ForMember(dest => dest.EndPosition, opt => opt.MapFrom(src => src.EndPosition))
            .ForMember(dest => dest.EndTimestamp, opt => opt.MapFrom(src => src.EndTimestamp))
            .ForMember(dest => dest.StartMileage, opt => opt.MapFrom(src => src.StartMileage))
            .ForMember(dest => dest.StartPosition, opt => opt.MapFrom(src => src.StartPosition))
            .ForMember(dest => dest.StartTimestamp, opt => opt.MapFrom(src => src.StartTimestamp))
            .ForMember(dest => dest.TachographActivity, opt => opt.MapFrom(src => src.TachographActivity));
        CreateMap<CardDTO, Card>()
            .ForMember(dest => dest.CardId, opt => opt.MapFrom(src => src.CardId))
            .ForMember(dest => dest.CardConsecutiveIndex, opt => opt.MapFrom(src => src.CardConsecutiveIndex))
            .ForMember(dest => dest.CardRenewalIndex, opt => opt.MapFrom(src => src.CardRenewalIndex))
            .ForMember(dest => dest.CardReplacementIndex, opt => opt.MapFrom(src => src.CardReplacementIndex));
        CreateMap<TachographInformationDTO, TachographInformation>()
            .ForMember(dest => dest.CardId, opt => opt.MapFrom(src => src.Card.CardId))
            .ForMember(dest => dest.CardSlot, opt => opt.MapFrom(src => src.CardSlot));
    }
}