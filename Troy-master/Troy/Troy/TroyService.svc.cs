using DataContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using DataContract.Contract;
using DataContract.Filters;
using Repository = DataLayer.Repository;

namespace Troy
{
    public class TroyService : IServiceContract
    {
        public void DeleteAccomodatie(int id)
        {
            var delete = new Repository.Accomodatie();
            delete.DeleteAccomodatie(id);
        }

        public void DeleteAccomodatieFaciliteit(int id)
        {
            var delete = new Repository.AccomodatieFaciliteit();
            delete.DeleteAccomodatieFaciliteit(id);
        }

        public void DeleteAdres(int id)
        {
            var delete = new Repository.Adres();
            delete.DeleteAdres(id);
        }

        public void DeleteDienst(int id)
        {
            var delete = new Repository.Dienst();
            delete.DeleteDienst(id);
        }

        public void DeleteFaciliteit(int id)
        {
            var delete = new Repository.Faciliteit();
            delete.DeleteFaciliteit(id);
        }

        public void DeleteGebruiker(int id)
        {
            var delete = new Repository.Gebruiker();
            delete.DeleteGebruiker(id);
        }

        public void DeletePrijs(int id)
        {
            var delete = new Repository.Prijs();
            delete.DeletePrijs(id);
        }

        public void DeleteReservatie(int id)
        {
            var delete = new Repository.Reservatie();
            delete.DeleteReservatie(id);
        }

        public void DeleteResort(int id)
        {
            var delete = new Repository.Resort();
            delete.DeleteResort(id);
        }

        public void DeleteType(int id)
        {
            var delete = new Repository.Type();
            delete.DeleteType(id);
        }

        public void DeleteUuid(int id)
        {
            var delete = new Repository.Uuid();
            delete.DeleteUuid(id);
        }

        public DataContract.Contract.Accomodatie GetAccomodatieid(int id)
        {
            var getId = new Repository.Accomodatie();
            return getId.GetAccomodatieid(id);
        }

        public DataContract.Contract.AccomodatieFaciliteit GetAccomodatieFaciliteitid(int id)
        {
            var getId = new Repository.AccomodatieFaciliteit();
            return getId.GetAccomodatieFaciliteitid(id);
        }

        public DataContract.Contract.Adres GetAdresid(int id)
        {
            var getId = new Repository.Adres();
            return getId.GetAdresid(id);
        }

        public DataContract.Contract.Dienst GetDienstid(int id)
        {
            var getId = new Repository.Dienst();
            return getId.GetDienstid(id);
        }

        public DataContract.Contract.Faciliteit GetFaciliteitid(int id)
        {
            var getId = new Repository.Faciliteit();
            return getId.GetFaciliteitid(id);
        }

        public DataContract.Contract.Gebruiker GetGebruikerid(int id)
        {
            var getId = new Repository.Gebruiker();
            return getId.GetGebruikerid(id);
        }

        public DataContract.Contract.Prijs GetPrijsid(int id)
        {
            var getId = new Repository.Prijs();
            return getId.GetPrijsid(id);
        }

        public DataContract.Contract.Reservatie GetReservatieid(int id)
        {
            var getId = new Repository.Reservatie();
            return getId.GetReservatieid(id);
        }

        public DataContract.Contract.Resort GetResortid(int id)
        {
            var getId = new Repository.Resort();
            return getId.GetResortid(id);
        }

        public DataContract.Contract.Type GetTypeid(int id)
        {
            var getId = new Repository.Type();
            return getId.GetTypeid(id);
        }

        public DataContract.Contract.Uuid GetUuid(int id)
        {
            var getId = new Repository.Uuid();
            return getId.GetUuidid(id);
        }

        public List<DataContract.Contract.Accomodatie> GetAccomodatie(DataContract.Filters.Accomodatie filter)
        {
            var get = new Repository.Accomodatie();
            return get.GetAccomodatie(filter);
        }

        public List<DataContract.Contract.AccomodatieFaciliteit> GetAccomodatieFaciliteit(DataContract.Filters.AccomodatieFaciliteit filter)
        {
            var get = new Repository.AccomodatieFaciliteit();
            return get.GetAccomodatieFaciliteit(filter);
        }

        public List<DataContract.Contract.Adres> GetAdres(DataContract.Filters.Adres filter)
        {
            var get = new Repository.Adres();
            return get.GetAdres(filter);
        }

        public List<DataContract.Contract.Dienst> GetDienst(DataContract.Filters.Dienst filter)
        {
            var get = new Repository.Dienst();
            return get.GetDienst(filter);
        }

        public List<DataContract.Contract.Faciliteit> GetFaciliteit(DataContract.Filters.Faciliteit filter)
        {
            var get = new Repository.Faciliteit();
            return get.GetFaciliteit(filter);
        }

        public List<DataContract.Contract.Gebruiker> GetGebruiker(DataContract.Filters.Gebruiker filter)
        {
            var get = new Repository.Gebruiker();
            return get.GetGebruiker(filter);
        }

        public List<DataContract.Contract.Prijs> GetPrijs(DataContract.Filters.Prijs filter)
        {
            var get = new Repository.Prijs();
            return get.GetPrijs(filter);
        }

        public List<DataContract.Contract.Reservatie> GetReservatie(DataContract.Filters.Reservatie filter)
        {
            var get = new Repository.Reservatie();
            return get.GetReservatie(filter);
        }

        public List<DataContract.Contract.Resort> GetResort(DataContract.Filters.Resort filter)
        {
            var get = new Repository.Resort();
            return get.GetResort(filter);
        }

        public List<DataContract.Contract.Type> GetType(DataContract.Filters.Type filter)
        {
            var get = new Repository.Type();
            return get.GetType(filter);
        }

        public List<DataContract.Contract.Uuid> GetUuid(DataContract.Filters.Uuid filter)
        {
            var zoek = new Repository.Uuid();
            return zoek.GetUuid(filter);
        }

        public void UpdateAccomodatie(DataContract.Contract.Accomodatie contact)
        {
            var repo = new Repository.Accomodatie();
            repo.UpdateAccomodatie(contact);
        }

        public void UpdateAccomodatieFaciliteit(DataContract.Contract.AccomodatieFaciliteit contact)
        {
            var repo = new Repository.AccomodatieFaciliteit();
            repo.UpdateAccomodatieFaciliteit(contact);
        }

        public void UpdateAdres(DataContract.Contract.Adres contact)
        {
            var repo = new Repository.Adres();
            repo.UpdateAdres(contact);
        }

        public void UpdateDienst(DataContract.Contract.Dienst contact)
        {
            var repo = new Repository.Dienst();
            repo.UpdateDienst(contact);
        }

        public void UpdateFaciliteit(DataContract.Contract.Faciliteit contact)
        {
            var repo = new Repository.Faciliteit();
            repo.UpdateFaciliteit(contact);
        }

        public void UpdateGebruiker(DataContract.Contract.Gebruiker contact)
        {
            var repo = new Repository.Gebruiker();
            repo.UpdateGebruiker(contact);
        }

        public void UpdatePrijs(DataContract.Contract.Prijs contact)
        {
            var repo = new Repository.Prijs();
            repo.UpdatePrijs(contact);
        }

        public void UpdateReservatie(DataContract.Contract.Reservatie contact)
        {
            var repo = new Repository.Reservatie();
            repo.UpdateReservatie(contact);
        }

        public void UpdateResort(DataContract.Contract.Resort contact)
        {
            var repo = new Repository.Resort();
            repo.UpdateResort(contact);
        }

        public void UpdateType(DataContract.Contract.Type contact)
        {
            var repo = new Repository.Type();
            repo.UpdateType(contact);
        }

        public void UpdateUuid(DataContract.Contract.Uuid contact)
        {
            var repo = new Repository.Uuid();
            repo.UpdateUuid(contact);
        }
    }
}
