using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Contact = DataContract.Contract.Faciliteit;
using Filter = DataContract.Filters.Faciliteit;
using Entity = DataLayer.Entities.Faciliteit;

namespace DataLayer.Repository
{
    public class Faciliteit
    {
        public List<Contact> GetFaciliteit(Filter filter)
        {
            using (var connectie = new Connectie())
            {
                var query = from item in connectie.Faciliteit
                            select item;
                if (filter.id > 0)
                {
                    query = from item in query
                            where item.id == filter.id
                            select item;
                }
                if (!String.IsNullOrEmpty(filter.faciliteit))
                {
                    query = from item in query
                            where item.faciliteit == filter.faciliteit
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
        /// DeleteFaciliteit
        /// </summary>
        /// <param name="id"></param>
        public void DeleteFaciliteit(int id)
        {
            using (var context = new Connectie())
            {
                var query = (from b in context.Faciliteit
                             where b.id == id
                             select b).FirstOrDefault();
                if (query != null)
                {
                    context.Faciliteit.Remove(query);
                    context.SaveChanges();
                }
            }
        }

        /// <summary>
        /// GetFaciliteit
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Contact GetFaciliteitid(int id)
        {
            using (var context = new Connectie())
            {
                var query = from b in context.Faciliteit
                            where b.id == id
                            orderby b.id
                            select b;
                var resulaat = map(query);
                return resulaat[0];
            }
        }

        /// <summary>
        /// het update van de faciliteit gegevens en of het toevoegen er van 
        /// </summary>
        /// <param name="Faciliteit"></param>
        /// <returns></returns>
        public int UpdateFaciliteit(Contact contract)
        {
            Entity entity = map(contract);

            using (var context = new Connectie())
            {
                if (contract.id == 0)
                {
                    context.Faciliteit.Add(entity);
                }
                else
                {
                    var query = from b in context.Faciliteit
                                where b.id == contract.id
                                select b;

                    context.Entry(query.First()).CurrentValues.SetValues(entity);
                }
                context.SaveChanges();

                return context.Faciliteit.First().id;
            }
        }
        private Entity map(Contact contact)
        {
            return mapFaciliteit(contact);
        }

        private List<Contact> map(IEnumerable<Entity> list)
        {
            var resultaat = new List<Contact>();
            foreach (var item in list)
            {
                var Faciliteit = mapFaciliteit(item);
                resultaat.Add(Faciliteit);

            }
            return resultaat;
        }

        private static Entity mapFaciliteit(Contact item)
        {
            return new Entity()
            {
                id = item.id,
                faciliteit = item.faciliteit,
                resortid = item.resortid
            };
        }

        private static Contact mapFaciliteit(Entity item)
        {
            return new Contact()
            {
                id = item.id,
                faciliteit = item.faciliteit,
                resortid = item.resortid
            };
        }
    }
}
    
