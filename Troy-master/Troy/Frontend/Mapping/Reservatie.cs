using AutoMapper;
using Data = DataContract.Contract;
using Model = Frontend.Models;
namespace Frontend.Mapping
{
    public static class Reservatie
    {
        public static IMapperConfigurationExpression AddReservatieMapper(this IMapperConfigurationExpression configExpression)
        {
            configExpression.CreateMap<Data.Reservatie, Model.ReservatieModel>().ReverseMap();
            return configExpression;
        }
    }
}