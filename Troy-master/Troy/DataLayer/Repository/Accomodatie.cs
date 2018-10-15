using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Contact = DataContract.Contract.Accomodatie;
using Filter = DataContract.Filters.Accomodatie;
using Entity = DataLayer.Entities.Accomodatie;

namespace DataLayer.Repository
{
    public class Accomodatie
    {
        public List<Contact> GetAccomodatie(Filter filter)
        {

            using (var connectie = new Connectie())
            {
                var query = from item in connectie.Accomodatie
                            select item;
                if (filter.id > 0)
                {
                    query = from item in query
                            where item.id == filter.id
                            select item;
                }
                if (!String.IsNullOrEmpty(filter.oppervlakte))
                {
                    query = from item in query
                            where item.oppervlakte == filter.oppervlakte
                            select item;
                }
                if (filter.slaapkamers > 0)
                {
                    query = from item in query
                            where item.slaapkamers == filter.slaapkamers
                            select item;
                }
                if (filter.autos > 0)
                {
                    query = from item in query
                            where item.autos == filter.autos
                            select item;
                }
                if (filter.typeid > 0)
                {
                    query = from item in query
                            where item.typeid == filter.typeid
                            select item;
                }
                return map(query);
            }
        }

        /// <summary>
        /// DeleteAccomodatie
        /// </summary>
        /// <param name="id"></param>
        public void DeleteAccomodatie(int id)
        {
            using (var context = new Connectie())
            {
                var query = (from b in context.Accomodatie
                             where b.id == id
                             select b).FirstOrDefault();
                if (query != null)
                {
                    context.Accomodatie.Remove(query);
                    context.SaveChanges();
                }
            }
        }

        /// <summary>
        /// GetAccomodatie
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Contact GetAccomodatieid(int id)
        {
            using (var context = new Connectie())
            {
                var query = from b in context.Accomodatie
                            where b.id == id
                            orderby b.id
                            select b;
                var resulaat = map(query);
                return resulaat[0];
            }
        }

        /// <summary>
        /// het update van de afdeling gegevens en of het toevoegen er van 
        /// </summary>
        /// <param name="afdeling"></param>
        /// <returns></returns>
        public int UpdateAccomodatie(Contact contract)
        {
            Entity entity = map(contract);

            using (var context = new Connectie())
            {
                if (contract.id == 0)
                {
                    context.Accomodatie.Add(entity);
                }
                else
                {
                    var query = from b in context.Accomodatie
                                where b.id == contract.id
                                select b;

                    context.Entry(query.First()).CurrentValues.SetValues(entity);
                }
                context.SaveChanges();

                return context.Accomodatie.First().id;
            }
        }
        //mapping
        private Entity map(Contact contact)
        {
            return mapAccomodatie(contact);
        }

        private List<Contact> map(IEnumerable<Entity> list)
        {
            var resultaat = new List<Contact>();
            foreach (var item in list)
            {
                var accomodatie = mapAccomodatie(item);
                resultaat.Add(accomodatie);

            }
            return resultaat;
        }

        private static Entity mapAccomodatie(Contact item)
        {
            return new Entity()
            {
                id = item.id,
                oppervlakte = item.oppervlakte,
                slaapkamers = item.slaapkamers,
                autos = item.autos,
                typeid = item.typeid
            };
        }

        private static Contact mapAccomodatie(Entity item)
        {
            return new Contact()
            {
                id = item.id,
                oppervlakte = item.oppervlakte,
                slaapkamers = item.slaapkamers,
                autos = item.autos,
                typeid = item.typeid
            };
        }
    }
}