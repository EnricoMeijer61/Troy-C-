using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Contact = DataContract.Contract.Type;
using Filter = DataContract.Filters.Type;
using Entity = DataLayer.Entities.Type;

namespace DataLayer.Repository
{
    public class Type
    {
        public List<Contact> GetType(Filter filter)
        {
            using (var connectie = new Connectie())
            {
                var query = from item in connectie.Type
                            select item;
                if (filter.id > 0)
                {
                    query = from item in query
                            where item.id == filter.id
                            select item;
                }
                if (filter.type > 0)
                {
                    query = from item in query
                            where item.type == filter.type
                            select item;
                }
                if (!String.IsNullOrEmpty(filter.bio))
                {
                    query = from item in query
                            where item.bio == filter.bio
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
        /// DeleteType
        /// </summary>
        /// <param name="id"></param>
        public void DeleteType(int id)
        {
            using (var context = new Connectie())
            {
                var query = (from b in context.Type
                             where b.id == id
                             select b).FirstOrDefault();
                if (query != null)
                {
                    context.Type.Remove(query);
                    context.SaveChanges();
                }
            }
        }

        /// <summary>
        /// GetType
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Contact GetTypeid(int id)
        {
            using (var context = new Connectie())
            {
                var query = from b in context.Type
                            where b.id == id
                            orderby b.id
                            select b;
                var resulaat = map(query);
                return resulaat[0];
            }
        }

        /// <summary>
        /// het update van de type gegevens en of het toevoegen er van 
        /// </summary>
        /// <param name="Type"></param>
        /// <returns></returns>
        public int UpdateType(Contact contract)
        {
            Entity entity = map(contract);

            using (var context = new Connectie())
            {
                if (contract.id == 0)
                {
                    context.Type.Add(entity);
                }
                else
                {
                    var query = from b in context.Type
                                where b.id == contract.id
                                select b;

                    context.Entry(query.First()).CurrentValues.SetValues(entity);
                }
                context.SaveChanges();

                return context.Type.First().id;
            }
        }
        private Entity map(Contact contact)
        {
            return mapType(contact);
        }

        private List<Contact> map(IEnumerable<Entity> list)
        {
            var resultaat = new List<Contact>();
            foreach (var item in list)
            {
                var Type = mapType(item);
                resultaat.Add(Type);

            }
            return resultaat;
        }

        private static Entity mapType(Contact item)
        {
            return new Entity()
            {
                id = item.id,
                type = item.type,
                bio = item.bio,
                resortid = item.resortid
            };
        }

        private static Contact mapType(Entity item)
        {
            return new Contact()
            {
                id = item.id,
                type = item.type,
                bio = item.bio,
                resortid = item.resortid

            };
        }
    }
}
    
