using DataContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using DataContract.Contract;
using DataContract.Filters;

namespace Frontend.Service
{
    public class ServiceClient : IServiceContract
    {
        public void DeleteAccomodatie(int id)
        {
            this.DeleteAccomodatie(id);
        }

        public void DeleteAccomodatieFaciliteit(int id)
        {
            this.DeleteAccomodatieFaciliteit(id);
        }

        public void DeleteAdres(int id)
        {
            this.DeleteAdres(id);
        }

        public void DeleteDienst(int id)
        {
            this.DeleteDienst(id);
        }

        public void DeleteFaciliteit(int id)
        {
            this.DeleteFaciliteit(id);
        }

        public void DeleteGebruiker(int id)
        {
            this.DeleteGebruiker(id);
        }

        public void DeletePrijs(int id)
        {
            this.DeletePrijs(id);
        }

        public void DeleteReservatie(int id)
        {
            this.DeleteReservatie(id);
        }

        public void DeleteResort(int id)
        {
            this.DeleteResort(id);
        }

        public void DeleteType(int id)
        {
            this.DeleteType(id);
        }

        public void DeleteUuid(int id)
        {
            this.DeleteUuid(id);
        }

        public DataContract.Contract.Adres GetAdresid(int id)
        {
            return this.GetAdresid(id);
        }

        public DataContract.Contract.AccomodatieFaciliteit GetAccomodatieFaciliteitid(int id)
        {
            return this.GetAccomodatieFaciliteitid(id);
        }

        public DataContract.Contract.Accomodatie GetAccomodatieid(int id)
        {
            return this.GetAccomodatieid(id);
        }

        public DataContract.Contract.Dienst GetDienstid(int id)
        {
            return this.GetDienstid(id);
        }
        public DataContract.Contract.Faciliteit GetFaciliteitid(int id)
        {
            return this.GetFaciliteitid(id);
        }

        public DataContract.Contract.Gebruiker GetGebruikerid(int id)
        {
            return this.GetGebruikerid(id);
        }

        public DataContract.Contract.Prijs GetPrijsid(int id)
        {
            return this.GetPrijsid(id);
        }

        public DataContract.Contract.Reservatie GetReservatieid(int id)
        {
            return this.GetReservatieid(id);
        }

        public DataContract.Contract.Resort GetResortid(int id)
        {
            return this.GetResortid(id);
        }

        public DataContract.Contract.Type GetTypeid(int id)
        {
            return this.GetTypeid(id);
        }

        public DataContract.Contract.Uuid GetUuid(int id)
        {
            return this.GetUuid(id);
        }

        public List<DataContract.Contract.Resort> GetResort(DataContract.Filters.Resort filter)
        {
            return this.GetResort(filter);
        }

        public List<DataContract.Contract.Accomodatie> GetAccomodatie(DataContract.Filters.Accomodatie filter)
        {
            return this.GetAccomodatie(filter);
        }

        public List<DataContract.Contract.AccomodatieFaciliteit> GetAccomodatieFaciliteit(DataContract.Filters.AccomodatieFaciliteit filter)
        {
            return this.GetAccomodatieFaciliteit(filter);
        }

        public List<DataContract.Contract.Adres> GetAdres(DataContract.Filters.Adres filter)
        {
            return this.GetAdres(filter);
        }

        public List<DataContract.Contract.Dienst> GetDienst(DataContract.Filters.Dienst filter)
        {
            return this.GetDienst(filter);
        }

        public List<DataContract.Contract.Faciliteit> GetFaciliteit(DataContract.Filters.Faciliteit filter)
        {
            return this.GetFaciliteit(filter);
        }

        public List<DataContract.Contract.Gebruiker> GetGebruiker(DataContract.Filters.Gebruiker filter)
        {
            return this.GetGebruiker(filter);
        }

        public List<DataContract.Contract.Prijs> GetPrijs(DataContract.Filters.Prijs filter)
        {
            return this.GetPrijs(filter);
        }

        public List<DataContract.Contract.Reservatie> GetReservatie(DataContract.Filters.Reservatie filter)
        {
            return this.GetReservatie(filter);
        }

        public List<DataContract.Contract.Type> GetType(DataContract.Filters.Type filter)
        {
            return this.GetType(filter);
        }

        public List<DataContract.Contract.Uuid> GetUuid(DataContract.Filters.Uuid filter)
        {
            return this.GetUuid(filter);
        }

        public void UpdateAccomodatie(DataContract.Contract.Accomodatie contact)
        {
            this.UpdateAccomodatie(contact);
        }

        public void UpdateAccomodatieFaciliteit(DataContract.Contract.AccomodatieFaciliteit contact)
        {
            this.UpdateAccomodatieFaciliteit(contact);
        }

        public void UpdateAdres(DataContract.Contract.Adres contact)
        {
            this.UpdateAdres(contact);
        }

        public void UpdateDienst(DataContract.Contract.Dienst contact)
        {
            this.UpdateDienst(contact);
        }

        public void UpdateFaciliteit(DataContract.Contract.Faciliteit contact)
        {
            this.UpdateFaciliteit(contact);
        }

        public void UpdateGebruiker(DataContract.Contract.Gebruiker contact)
        {
            this.UpdateGebruiker(contact);
        }

        public void UpdatePrijs(DataContract.Contract.Prijs contact)
        {
            this.UpdatePrijs(contact);
        }

        public void UpdateReservatie(DataContract.Contract.Reservatie contact)
        {
            this.UpdateReservatie(contact);
        }

        public void UpdateResort(DataContract.Contract.Resort contact)
        {
            this.UpdateResort(contact);
        }

        public void UpdateType(DataContract.Contract.Type contact)
        {
            this.UpdateType(contact);
        }

        public void UpdateUuid(DataContract.Contract.Uuid contact)
        {
            this.UpdateUuid(contact);
        }
    }
}