using AutoMapper;
using Data = DataContract.Contract;
using Model = Frontend.Models;

namespace Frontend.Mapping
{
    public static class AccomodatieFaciliteit
    {
        public static IMapperConfigurationExpression AddAccomodatieFaciliteitMapper(this IMapperConfigurationExpression configExpression)
        {
            configExpression.CreateMap<Data.AccomodatieFaciliteit, Model.AccomodatieFaciliteitModel>().ReverseMap();
            return configExpression;
        }
    }
}