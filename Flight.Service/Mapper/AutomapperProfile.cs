using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using IO.Swagger.Model;
using Flight.Model;
using System.Linq.Expressions;
using System.Globalization;

namespace Flight.Service.Mapper
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<string, double>().ConvertUsing(s => Convert.ToDouble(s, CultureInfo.InvariantCulture));

            CreateMap<string, DateTime>().ConvertUsing(new DateTimeTypeConverter().Convert);

            CreateMap<FlightSearchSegment, Model.FlightSegmentDTO>()
                .ForMember(dest => dest.FlightSagmentId, o => o.Ignore())
                .ForMember(dest => dest.DepartsAt, o => o.MapFrom(s => s.DepartsAt)) 
                .ForMember(dest => dest.ArrivesAt, o => o.MapFrom(s => s.ArrivesAt)) 
                .ForMember(dest => dest.Origin, o => o.MapFrom(s => s.Origin._Airport))
                .ForMember(dest => dest.Destination, o => o.MapFrom(s => s.Destination._Airport))
                .ForMember(dest => dest.FlightNumber, o => o.MapFrom(s => s.FlightNumber)) 
                .ForMember(dest => dest.Aircraft, o => o.MapFrom( s => s.Aircraft));

            CreateMap<FlightSearchBound, Model.FlightBoundDTO>()
                .ForMember(dest => dest.FlightBoundId, o => o.Ignore())
                .ForMember(dest => dest.Flights, o => o.MapFrom(s => s.Flights))
                .ForMember(dest => dest.Duration,o => o.MapFrom(s => s.Duration));

            CreateMap<FlightSearchItinerary, Model.FlightItinearyDTO>()
                 .ForMember(dest => dest.ItinearyId, o => o.Ignore())
                 .ForMember(dest => dest.Outbound, o => o.MapFrom(s => s.Outbound))
                 .ForMember(dest => dest.Inbound, o => o.MapFrom(s => s.Inbound));

            CreateMap<FlightSearchPrice, Model.PriceSegmentDTO>()
                .ForMember(dest => dest.PriceSegmentId, o => o.Ignore())
                .ForMember(dest => dest.TotalPrice, o => o.MapFrom(s => s.TotalPrice))
                .ForMember(dest => dest.PricePerAdult, o => o.MapFrom(s => s.PricePerAdult.TotalFare)) 
                .ForMember(dest => dest.PricePerChild, o => o.MapFrom(s => s.PricePerChild.TotalFare));

            CreateMap<LowFareSearchResult, Model.FlightSearchResultDTO>()
                 .ForMember(dest => dest.SearchResultId, o => o.Ignore())
                 .ForMember(dest => dest.Fare, o => o.MapFrom(s => s.Fare));

            CreateMap<LowFareSearchResponse, Model.FlightSearchResponeDTO>()
                 .ForMember(dest => dest.ResponeId, o => o.Ignore())
                 .ForMember(dest => dest.DepartureDate, o => o.Ignore())
                 .ForMember(dest => dest.ReturnDate, o => o.Ignore())
                 .ForMember(dest => dest.Origin, o => o.Ignore())
                 .ForMember(dest => dest.Destination, o => o.Ignore())
                 .ForMember(dest => dest.Adults, o => o.Ignore())
                 .ForMember(dest => dest.Childs, o => o.Ignore());
        }

    }
}
