using AutoMapper;
using Data = DataContract.Contract;
using Model = Frontend.Models;

namespace Frontend.Mapping
{

    public static class Uuid
    {
        public static IMapperConfigurationExpression AddUuidMapper(this IMapperConfigurationExpression configExpression)
        {
            configExpression.CreateMap<Data.Uuid, Model.UuidModel>().ReverseMap();
            return configExpression;
        }
    }
}