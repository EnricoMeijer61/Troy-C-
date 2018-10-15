using AutoMapper;
using Data = DataContract.Contract;
using Model = Frontend.Models;

namespace Frontend.Mapping
{
    public static class Accomodatie
    {
        public static IMapperConfigurationExpression AddAccomodatieMapper(this IMapperConfigurationExpression configExpression)
        {
            configExpression.CreateMap<Data.Accomodatie, Model.AccomodatieModel>().ReverseMap();
            return configExpression;
        }
    }
}