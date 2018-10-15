using AutoMapper;
using Data = DataContract.Contract;
using Model = Frontend.Models;

namespace Frontend.Mapping
{
    public static class Gebruiker
    {
        public static IMapperConfigurationExpression AddGebruikerMapper(this IMapperConfigurationExpression configExpression)
        {
            configExpression.CreateMap<Data.Gebruiker, Model.GebruikerModel>().ReverseMap();
            return configExpression;
        }
    }
}