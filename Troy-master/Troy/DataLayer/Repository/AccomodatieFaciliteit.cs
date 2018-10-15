using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Contact = DataContract.Contract.AccomodatieFaciliteit;
using Filter = DataContract.Filters.AccomodatieFaciliteit;
using Entity = DataLayer.Entities.AccomodatieFaciliteit;

namespace DataLayer.Repository
{
    public class AccomodatieFaciliteit
    {
        public List<Contact> GetAccomodatieFaciliteit(Filter filter)
        {
            using (var connectie = new Connectie())
            {
                var query = from item in connectie.AccomodatieFaciliteit
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
                if (filter.accomodatieid > 0)
                {
                    query = from item in query
                            where item.accomodatieid == filter.accomodatieid
                            select item;
                }
                return map(query);
            }
        }

        /// <summary>
        /// DeleteAccomodatieFaciliteit
        /// </summary>
        /// <param name="id"></param>
        public void DeleteAccomodatieFaciliteit(int id)
        {
            using (var context = new Connectie())
            {
                var query = (from b in context.AccomodatieFaciliteit
                             where b.id == id
                             select b).FirstOrDefault();
                if (query != null)
                {
                    context.AccomodatieFaciliteit.Remove(query);
                    context.SaveChanges();
                }
            }
        }

        /// <summary>
        /// GetAccomodatieFaciliteit
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Contact GetAccomodatieFaciliteitid(int id)
        {
            using (var context = new Connectie())
            {
                var query = from b in context.AccomodatieFaciliteit
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
        public int UpdateAccomodatieFaciliteit(Contact contract)
        {
            Entity entity = map(contract);

            using (var context = new Connectie())
            {
                if (contract.id == 0)
                {
                    context.AccomodatieFaciliteit.Add(entity);
                }
                else
                {
                    var query = from b in context.AccomodatieFaciliteit
                                where b.id == contract.id
                                select b;

                    context.Entry(query.First()).CurrentValues.SetValues(entity);
                }
                context.SaveChanges();

                return context.AccomodatieFaciliteit.First().id;
            }
        }
        private Entity map(Contact contact)
        {
            return mapAccomodatieFaciliteit(contact);
        }

        private List<Contact> map(IEnumerable<Entity> list)
        {
            var resultaat = new List<Contact>();
            foreach (var item in list)
            {
                var accomodatieFaciliteit = mapAccomodatieFaciliteit(item);
                resultaat.Add(accomodatieFaciliteit);

            }
            return resultaat;
        }

        private static Entity mapAccomodatieFaciliteit(Contact item)
        {
            return new Entity()
            {
                id = item.id,
                faciliteit = item.faciliteit,
                accomodatieid = item.accomodatieid
                
            };
        }

        private static Contact mapAccomodatieFaciliteit(Entity item)
        {
            return new Contact()
            {
                id = item.id,
                faciliteit = item.faciliteit,
                accomodatieid = item.accomodatieid
            };
        }
    }
}
    
