using AutoMapper;
using Data = DataContract.Contract;
using Model = Frontend.Models;

namespace Frontend.Mapping
{
    public static class Prijs
    {
        public static IMapperConfigurationExpression AddPrijsMapper(this IMapperConfigurationExpression configExpression)
        {
            configExpression.CreateMap<Data.Prijs, Model.PrijsModel>().ReverseMap();
            return configExpression;
        }
    }
}