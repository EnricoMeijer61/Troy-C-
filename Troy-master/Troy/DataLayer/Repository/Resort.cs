using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Contact = DataContract.Contract.Resort;
using Filter = DataContract.Filters.Resort;
using Entity = DataLayer.Entities.Resort;

namespace DataLayer.Repository
{
    public class Resort
    {
        public List<Contact> GetResort(Filter filter)
        {
            using (var connectie = new Connectie())
            {
                var query = from item in connectie.Resort
                            select item;
                if (filter.id > 0)
                {
                    query = from item in query
                            where item.id == filter.id
                            select item;
                }
                if (!String.IsNullOrEmpty(filter.naam))
                {
                    query = from item in query
                            where item.naam == filter.naam
                            select item;
                }
                if (!String.IsNullOrEmpty(filter.bio))
                {
                    query = from item in query
                            where item.bio == filter.bio
                            select item;
                }
                return map(query);
            }
        }

        /// <summary>
        /// DeleteResort
        /// </summary>
        /// <param name="id"></param>
        public void DeleteResort(int id)
        {
            using (var context = new Connectie())
            {
                var query = (from b in context.Resort
                             where b.id == id
                             select b).FirstOrDefault();
                if (query != null)
                {
                    context.Resort.Remove(query);
                    context.SaveChanges();
                }
            }
        }

        /// <summary>
        /// GetResort
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Contact GetResortid(int id)
        {
            using (var context = new Connectie())
            {
                var query = from b in context.Resort
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
        public int UpdateResort(Contact contract)
        {
            Entity entity = map(contract);

            using (var context = new Connectie())
            {
                if (contract.id == 0)
                {
                    context.Resort.Add(entity);
                }
                else
                {
                    var query = from b in context.Resort
                                where b.id == contract.id
                                select b;

                    context.Entry(query.First()).CurrentValues.SetValues(entity);
                }
                context.SaveChanges();

                return context.Resort.First().id;
            }
        }
        private Entity map(Contact contact)
        {
            return mapResort(contact);
        }

        private List<Contact> map(IEnumerable<Entity> list)
        {
            var resultaat = new List<Contact>();
            foreach (var item in list)
            {
                var Resort = mapResort(item);
                resultaat.Add(Resort);

            }
            return resultaat;
        }

        private static Entity mapResort(Contact item)
        {
            return new Entity()
            {
                id = item.id,
                naam = item.naam,
                bio = item.bio
            };
        }

        private static Contact mapResort(Entity item)
        {
            return new Contact()
            {
                id = item.id,
                naam = item.naam,
                bio = item.bio
            };
        }
    }
}
    
