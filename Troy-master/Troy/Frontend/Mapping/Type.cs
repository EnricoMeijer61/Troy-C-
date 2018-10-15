using AutoMapper;
using Data = DataContract.Contract;
using Model = Frontend.Models;

namespace Frontend.Mapping
{
    public static class Type
    {
        public static IMapperConfigurationExpression AddTypeMapper(this IMapperConfigurationExpression configExpression)
        {
            configExpression.CreateMap<Data.Type, Model.TypeModel>().ReverseMap();
            return configExpression;
        }
    }
}