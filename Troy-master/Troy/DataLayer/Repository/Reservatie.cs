using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Contact = DataContract.Contract.Reservatie;
using Filter = DataContract.Filters.Reservatie;
using Entity = DataLayer.Entities.Reservatie;

namespace DataLayer.Repository
{
    public class Reservatie
    {
        public List<Contact> GetReservatie(Filter filter)
        {
            using (var connectie = new Connectie())
            {
                var query = from item in connectie.Reservatie
                            select item;
                if (filter.id > 0)
                {
                    query = from item in query
                            where item.id == filter.id
                            select item;
                }
                if (filter.datum != null)
                {
                    query = from item in query
                            where item.datum == filter.datum
                            select item;
                }
                if (filter.start != null)
                {
                    query = from item in query
                            where item.start == filter.start
                            select item;
                }
                if (filter.eind != null)
                {
                    query = from item in query
                            where item.eind == filter.eind
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
                if (filter.accomodatieid > 0)
                {
                    query = from item in query
                            where item.accomodatieid == filter.accomodatieid
                            select item;
                }
                if (filter.dienstid > 0)
                {
                    query = from item in query
                            where item.dienstid == filter.dienstid
                            select item;
                }
                return map(query);
            }
        }

        /// <summary>
        /// DeleteReservatie
        /// </summary>
        /// <param name="id"></param>
        public void DeleteReservatie(int id)
        {
            using (var context = new Connectie())
            {
                var query = (from b in context.Reservatie
                             where b.id == id
                             select b).FirstOrDefault();
                if (query != null)
                {
                    context.Reservatie.Remove(query);
                    context.SaveChanges();
                }
            }
        }

        /// <summary>
        /// GetReservatie
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Contact GetReservatieid(int id)
        {
            using (var context = new Connectie())
            {
                var query = from b in context.Reservatie
                            where b.id == id
                            orderby b.id
                            select b;
                var resulaat = map(query);
                return resulaat[0];
            }
        }

        /// <summary>
        /// het update van de reservatie gegevens en of het toevoegen er van 
        /// </summary>
        /// <param name="Reservatie"></param>
        /// <returns></returns>
        public int UpdateReservatie(Contact contract)
        {
            Entity entity = map(contract);

            using (var context = new Connectie())
            {
                if (contract.id == 0)
                {
                    context.Reservatie.Add(entity);
                }
                else
                {
                    var query = from b in context.Reservatie
                                where b.id == contract.id
                                select b;

                    context.Entry(query.First()).CurrentValues.SetValues(entity);
                }
                context.SaveChanges();

                return context.Reservatie.First().id;
            }
        }
        private Entity map(Contact contact)
        {
            return mapReservatie(contact);
        }

        private List<Contact> map(IEnumerable<Entity> list)
        {
            var resultaat = new List<Contact>();
            foreach (var item in list)
            {
                var Reservatie = mapReservatie(item);
                resultaat.Add(Reservatie);

            }
            return resultaat;
        }

        private static Entity mapReservatie(Contact item)
        {
            return new Entity()
            {
                id = item.id,
                datum = item.datum,
                start = item.start,
                eind = item.eind,
                gebruikerid = item.gebruikerid,
                resortid = item.resortid,
                accomodatieid = item.accomodatieid,
                dienstid = item.dienstid
            
            };
        }

        private static Contact mapReservatie(Entity item)
        {
            return new Contact()
            {
                id = item.id,
                datum = item.datum,
                start = item.start,
                eind = item.eind,
                gebruikerid = item.gebruikerid,
                resortid = item.resortid,
                accomodatieid = item.accomodatieid,
                dienstid = item.dienstid
            };
        }
    }
}
    
