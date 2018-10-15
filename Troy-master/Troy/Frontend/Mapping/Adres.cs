using AutoMapper;
using Data = DataContract.Contract;
using Model = Frontend.Models;

namespace Frontend.Mapping
{
    public static class Adres
    {
        public static IMapperConfigurationExpression AddAdresMapper(this IMapperConfigurationExpression configExpression)
        {
            configExpression.CreateMap<Data.Adres, Model.AdresModel>().ReverseMap();
            return configExpression;
        }
    }
}