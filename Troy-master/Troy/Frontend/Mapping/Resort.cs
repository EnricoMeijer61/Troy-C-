using AutoMapper;
using Data = DataContract.Contract;
using Model = Frontend.Models;

namespace Frontend.Mapping
{

    public static class Resort
    {
        public static IMapperConfigurationExpression AddResortMapper(this IMapperConfigurationExpression configExpression)
        {
            configExpression.CreateMap<Data.Resort, Model.ResortModel>().ReverseMap();
            return configExpression;
        }
    }
}