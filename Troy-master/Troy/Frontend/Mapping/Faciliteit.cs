using AutoMapper;
using Data = DataContract.Contract;
using Model = Frontend.Models;

namespace Frontend.Mapping
{
    public static class Faciliteit
    {
        public static IMapperConfigurationExpression AddFaciliteitMapper(this IMapperConfigurationExpression configExpression)
        {
            configExpression.CreateMap<Data.Faciliteit, Model.FaciliteitModel>().ReverseMap();
            return configExpression;
        }
    }
}