using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Contact = DataContract.Contract.Prijs;
using Filter = DataContract.Filters.Prijs;
using Entity = DataLayer.Entities.Prijs;

namespace DataLayer.Repository
{
    public class Prijs
    {
        public List<Contact> GetPrijs(Filter filter)
        {
            using (var connectie = new Connectie())
            {
                var query = from item in connectie.Prijs
                            select item;
                if (filter.id > 0)
                {
                    query = from item in query
                            where item.id == filter.id
                            select item;
                }
                if (filter.prijs > 0)
                {
                    query = from item in query
                            where item.prijs == filter.prijs
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
        /// DeletePrijs
        /// </summary>
        /// <param name="id"></param>
        public void DeletePrijs(int id)
        {
            using (var context = new Connectie())
            {
                var query = (from b in context.Prijs
                             where b.id == id
                             select b).FirstOrDefault();
                if (query != null)
                {
                    context.Prijs.Remove(query);
                    context.SaveChanges();
                }
            }
        }

        /// <summary>
        /// GetPrijs
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Contact GetPrijsid(int id)
        {
            using (var context = new Connectie())
            {
                var query = from b in context.Prijs
                            where b.id == id
                            orderby b.id
                            select b;
                var resulaat = map(query);
                return resulaat[0];
            }
        }

        /// <summary>
        /// het update van de prijs gegevens en of het toevoegen er van 
        /// </summary>
        /// <param name="Prijs"></param>
        /// <returns></returns>
        public int UpdatePrijs(Contact contract)
        {
            Entity entity = map(contract);

            using (var context = new Connectie())
            {
                if (contract.id == 0)
                {
                    context.Prijs.Add(entity);
                }
                else
                {
                    var query = from b in context.Prijs
                                where b.id == contract.id
                                select b;

                    context.Entry(query.First()).CurrentValues.SetValues(entity);
                }
                context.SaveChanges();

                return context.Prijs.First().id;
            }
        }
        private Entity map(Contact contact)
        {
            return mapPrijs(contact);
        }

        private List<Contact> map(IEnumerable<Entity> list)
        {
            var resultaat = new List<Contact>();
            foreach (var item in list)
            {
                var Prijs = mapPrijs(item);
                resultaat.Add(Prijs);

            }
            return resultaat;
        }

        private static Entity mapPrijs(Contact item)
        {
            return new Entity()
            {
                id = item.id,
                prijs = item.prijs,
                accomodatieid = item.accomodatieid,
                dienstid = item.dienstid
            };
        }

        private static Contact mapPrijs(Entity item)
        {
            return new Contact()
            {
                id = item.id,
                prijs = item.prijs,
                accomodatieid = item.accomodatieid,
                dienstid = item.dienstid
            };
        }
    }
}
    
