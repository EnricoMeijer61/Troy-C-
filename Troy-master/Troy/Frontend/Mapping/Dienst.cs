using AutoMapper;
using Data = DataContract.Contract;
using Model = Frontend.Models;

namespace Frontend.Mapping
{
    public static class Dienst
    {
        public static IMapperConfigurationExpression AddDienstMapper(this IMapperConfigurationExpression configExpression)
        {
            configExpression.CreateMap<Data.Dienst, Model.DienstModel>().ReverseMap();
            return configExpression;
        }
    }
}