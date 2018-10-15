using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Contact = DataContract.Contract.Uuid;
using Filter = DataContract.Filters.Uuid;
using Entity = DataLayer.Entities.Uuid;

namespace DataLayer.Repository
{
    public class Uuid
    {
        public List<Contact> GetUuid(Filter filter)
        {
            using (var connectie = new Connectie())
            {
                var query = from item in connectie.Uuid
                            select item;
                if (filter.id > 0)
                {
                    query = from item in query
                            where item.id == filter.id
                            select item;
                }
                if (!String.IsNullOrEmpty(filter.uniqueidentifier))
                {
                    query = from item in query
                            where item.uniqueidentifier == filter.uniqueidentifier
                            select item;
                }
                return map(query);
            }
        }

        /// <summary>
        /// DeleteUuid
        /// </summary>
        /// <param name="id"></param>
        public void DeleteUuid(int id)
        {
            using (var context = new Connectie())
            {
                var query = (from b in context.Uuid
                             where b.id == id
                             select b).FirstOrDefault();
                if (query != null)
                {
                    context.Uuid.Remove(query);
                    context.SaveChanges();
                }
            }
        }

        /// <summary>
        /// GetUuid
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Contact GetUuidid(int id)
        {
            using (var context = new Connectie())
            {
                var query = from b in context.Uuid
                            where b.id == id
                            orderby b.id
                            select b;
                var resulaat = map(query);
                return resulaat[0];
            }
        }

        /// <summary>
        /// het update van de uuid gegevens en of het toevoegen er van 
        /// </summary>
        /// <param name="Uuid"></param>
        /// <returns></returns>
        public int UpdateUuid(Contact contract)
        {
            Entity entity = map(contract);

            using (var context = new Connectie())
            {
                if (contract.id == 0)
                {
                    context.Uuid.Add(entity);
                }
                else
                {
                    var query = from b in context.Uuid
                                where b.id == contract.id
                                select b;

                    context.Entry(query.First()).CurrentValues.SetValues(entity);
                }
                context.SaveChanges();

                return context.Uuid.First().id;
            }
        }
        private Entity map(Contact contact)
        {
            return mapUuid(contact);
        }

        private List<Contact> map(IEnumerable<Entity> list)
        {
            var resultaat = new List<Contact>();
            foreach (var item in list)
            {
                var Uuid = mapUuid(item);
                resultaat.Add(Uuid);

            }
            return resultaat;
        }

        private static Entity mapUuid(Contact item)
        {
            return new Entity()
            {
                id = item.id,
                uniqueidentifier = item.uniqueidentifier,
                gebruikerid = item.gebruikerid
            };
        }

        private static Contact mapUuid(Entity item)
        {
            return new Contact()
            {
                id = item.id,
                uniqueidentifier = item.uniqueidentifier,
                gebruikerid = item.gebruikerid
            };
        }
    }
}
    
