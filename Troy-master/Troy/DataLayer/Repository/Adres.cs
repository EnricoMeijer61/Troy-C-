using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Contact = DataContract.Contract.Adres;
using Filter = DataContract.Filters.Adres;
using Entity = DataLayer.Entities.Adres;

namespace DataLayer.Repository
{
    public class Adres
    {
        public List<Contact> GetAdres(Filter filter)
        {
            using (var connectie = new Connectie())
            {
                var query = from item in connectie.Adres
                            select item;
                if (filter.id > 0)
                {
                    query = from item in query
                            where item.id == filter.id
                            select item;
                }
                if (!String.IsNullOrEmpty(filter.land))
                {
                    query = from item in query
                            where item.land == filter.land
                            select item;
                }
                if (!String.IsNullOrEmpty(filter.stad))
                {
                    query = from item in query
                            where item.stad == filter.stad
                            select item;
                }
                if (!String.IsNullOrEmpty(filter.provincie))
                {
                    query = from item in query
                            where item.provincie == filter.provincie
                            select item;
                }
                if (!String.IsNullOrEmpty(filter.straat))
                {
                    query = from item in query
                            where item.straat == filter.straat
                            select item;
                }
                if (!String.IsNullOrEmpty(filter.postcode))
                {
                    query = from item in query
                            where item.postcode == filter.postcode
                            select item;
                }
                if (filter.telefoonnummer > 0)
                {
                    query = from item in query
                            where item.telefoonnummer == filter.telefoonnummer
                            select item;
                }
                if (!String.IsNullOrEmpty(filter.email))
                {
                    query = from item in query
                            where item.email == filter.email
                            select item;
                }
                if (filter.gebruikerid > 0)
                {
                    query = from item in query
                            where item.gebruikerid == filter.gebruikerid
                            select item;
                }
                if (filter.resortid > 0)
                {
                    query = from item in query
                            where item.resortid == filter.resortid
                            select item;
                }
                return map(query);
            }
        }

        /// <summary>
        /// DeleteAdres
        /// </summary>
        /// <param name="id"></param>
        public void DeleteAdres(int id)
        {
            using (var context = new Connectie())
            {
                var query = (from b in context.Adres
                             where b.id == id
                             select b).FirstOrDefault();
                if (query != null)
                {
                    context.Adres.Remove(query);
                    context.SaveChanges();
                }
            }
        }

        /// <summary>
        /// GetAdres
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Contact GetAdresid(int id)
        {
            using (var context = new Connectie())
            {
                var query = from b in context.Adres
                            where b.id == id
                            orderby b.id
                            select b;
                var resulaat = map(query);
                return resulaat[0];
            }
        }

        /// <summary>
        /// het update van de adres gegevens en of het toevoegen er van 
        /// </summary>
        /// <param name="Adres"></param>
        /// <returns></returns>
        public int UpdateAdres(Contact contract)
        {
            Entity entity = map(contract);

            using (var context = new Connectie())
            {
                if (contract.id == 0)
                {
                    context.Adres.Add(entity);
                }
                else
                {
                    var query = from b in context.Adres
                                where b.id == contract.id
                                select b;

                    context.Entry(query.First()).CurrentValues.SetValues(entity);
                }
                context.SaveChanges();

                return context.Adres.First().id;
            }
        }
        private Entity map(Contact contact)
        {
            return mapAdres(contact);
        }

        private List<Contact> map(IEnumerable<Entity> list)
        {
            var resultaat = new List<Contact>();
            foreach (var item in list)
            {
                var Adres = mapAdres(item);
                resultaat.Add(Adres);

            }
            return resultaat;
        }

        private static Entity mapAdres(Contact item)
        {
            return new Entity()
            {
                id = item.id,
                land = item.land,
                stad = item.stad,
                provincie = item.provincie,
                straat = item.straat,
                postcode = item.postcode,
                telefoonnummer = item.telefoonnummer,
                email = item.email,
                gebruikerid = item.gebruikerid,
                resortid = item.resortid

            };
        }

        private static Contact mapAdres(Entity item)
        {
            return new Contact()
            {
                id = item.id,
                land = item.land,
                stad = item.stad,
                provincie = item.provincie,
                straat = item.straat,
                postcode = item.postcode,
                telefoonnummer = item.telefoonnummer,
                email = item.email,
                gebruikerid = item.gebruikerid,
                resortid = item.resortid
            };
        }
    }
}
    
