using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Frontend.Mapping.Config
{
    public static class ConfigMapping
    {
        //private static readonly Log4net.Ilog log = Log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public static MapperConfiguration Config;

        public static IMapper Configureer()
        {
            if (Config == null)
            {
                //try
                //{
                Config = new MapperConfiguration(cfg => cfg.alleDefinities());
                //}
                //catch(Exception expn)
                //{
                //    log.Fata(expn.Message, expn);
                //    throw;
                //}
                //try
                //{
                Config.AssertConfigurationIsValid();
                //}
                //catch(AutoMapperConfigurationException expn)
                //{
                //    log.Fatal(expn.Message, expn);
                //}
            }
            return Config.CreateMapper();
        }

        static void alleDefinities(this IMapperConfigurationExpression configuratie)
        {
            configuratie.AddAccomodatieMapper();
            configuratie.AddAccomodatieMapper();
            configuratie.AddAdresMapper();
            configuratie.AddDienstMapper();
            configuratie.AddFaciliteitMapper();
            configuratie.AddGebruikerMapper();
            configuratie.AddPrijsMapper();
            configuratie.AddReservatieMapper();
            configuratie.AddResortMapper();
            configuratie.AddTypeMapper();
            configuratie.AddUuidMapper();
        }
    }
}