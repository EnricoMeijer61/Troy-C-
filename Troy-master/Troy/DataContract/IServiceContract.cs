using System.Collections.Generic;
using System.ServiceModel;
using Contact = DataContract.Contract;
using Filter = DataContract.Filters;

namespace DataContract
{
    [ServiceContract]
    public interface IServiceContract
    {
		[OperationContract]
        void UpdateAccomodatie(Contact.Accomodatie contact);

        [OperationContract]
        List<Contact.Accomodatie> GetAccomodatie(Filter.Accomodatie filter);

        [OperationContract]
        Contact.Accomodatie GetAccomodatieid(int id);

        [OperationContract]
        void DeleteAccomodatie(int id);


        [OperationContract]
        void UpdateAccomodatieFaciliteit(Contact.AccomodatieFaciliteit contact);

        [OperationContract]
        List<Contact.AccomodatieFaciliteit> GetAccomodatieFaciliteit(Filter.AccomodatieFaciliteit filter);

        [OperationContract]
        Contact.AccomodatieFaciliteit GetAccomodatieFaciliteitid(int id);

        [OperationContract]
        void DeleteAccomodatieFaciliteit(int id);


        [OperationContract]
        void UpdateAdres(Contact.Adres contact);

        [OperationContract]
        List<Contact.Adres> GetAdres(Filter.Adres filter);

        [OperationContract]
        Contact.Adres GetAdresid(int id);

        [OperationContract]
        void DeleteAdres(int id);


        [OperationContract]
        void UpdateDienst(Contact.Dienst contact);

        [OperationContract]
        List<Contact.Dienst> GetDienst(Filter.Dienst filter);

        [OperationContract]
        Contact.Dienst GetDienstid(int id);

        [OperationContract]
        void DeleteDienst(int id);


        [OperationContract]
        void UpdateFaciliteit(Contact.Faciliteit contact);

        [OperationContract]
        List<Contact.Faciliteit> GetFaciliteit(Filter.Faciliteit filter);

        [OperationContract]
        Contact.Faciliteit GetFaciliteitid(int id);

        [OperationContract]
        void DeleteFaciliteit(int id);


        [OperationContract]
        void UpdateGebruiker(Contact.Gebruiker contact);

        [OperationContract]
        List<Contact.Gebruiker> GetGebruiker(Filter.Gebruiker filter);

        [OperationContract]
        Contact.Gebruiker GetGebruikerid(int id);

        [OperationContract]
        void DeleteGebruiker(int id);


        [OperationContract]
        void UpdatePrijs(Contact.Prijs contact);

        [OperationContract]
        List<Contact.Prijs> GetPrijs(Filter.Prijs filter);

        [OperationContract]
        Contact.Prijs GetPrijsid(int id);

        [OperationContract]
        void DeletePrijs(int id);


        [OperationContract]
        void UpdateReservatie(Contact.Reservatie contact);

        [OperationContract]
        List<Contact.Reservatie> GetReservatie(Filter.Reservatie filter);

        [OperationContract]
        Contact.Reservatie GetReservatieid(int id);

        [OperationContract]
        void DeleteReservatie(int id);


        [OperationContract]
        void UpdateResort(Contact.Resort contact);

        [OperationContract]
        List<Contact.Resort> GetResort(Filter.Resort filter);

        [OperationContract]
        Contact.Resort GetResortid(int id);

        [OperationContract]
        void DeleteResort(int id);


        [OperationContract]
        void UpdateType(Contact.Type contact);

        [OperationContract]
        List<Contact.Type> GetType(Filter.Type filter);

        [OperationContract]
        Contact.Type GetTypeid(int id);

        [OperationContract]
        void DeleteType(int id);


        [OperationContract]
        void UpdateUuid(Contact.Uuid contact);

        [OperationContract]
        List<Contact.Uuid> GetUuid(Filter.Uuid filter);

        [OperationContract]
        Contact.Uuid GetUuid(int id);

        [OperationContract]
        void DeleteUuid(int id);

    }
}
