using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.DataFiles;
using Api.Helpers;
using Api.Models.Response;
using AutoMapper;

namespace Api.MappingConfigurations
{
    public class FundDataProfile : Profile
    {
        public FundDataProfile()
        {
            CreateMap<FundDetails, FundDataResponse>()
                .ForMember(x => x.CurrentUnitPrice, x => x.ConvertUsing(new RoundDecimalTwo(), "CurrentUnitPrice"))
                .ForMember(dest => dest.Code, opt => opt.MapFrom(src => src.MarketCode));


            // .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => src.Name));
        }
    }
}
