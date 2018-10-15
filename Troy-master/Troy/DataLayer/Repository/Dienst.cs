using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Contact = DataContract.Contract.Dienst;
using Filter = DataContract.Filters.Dienst;
using Entity = DataLayer.Entities.Dienst;

namespace DataLayer.Repository
{
    public class Dienst
    {
        public List<Contact> GetDienst(Filter filter)
        {
            using (var connectie = new Connectie())
            {
                var query = from item in connectie.Dienst
                            select item;
                if (filter.id > 0)
                {
                    query = from item in query
                            where item.id == filter.id
                            select item;
                }
                if (!String.IsNullOrEmpty(filter.dienst))
                {
                    query = from item in query
                            where item.dienst == filter.dienst
                            select item;
                }
                if (!String.IsNullOrEmpty(filter.zorg))
                {
                    query = from item in query
                            where item.zorg == filter.zorg
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
        /// DeleteDienst
        /// </summary>
        /// <param name="id"></param>
        public void DeleteDienst(int id)
        {
            using (var context = new Connectie())
            {
                var query = (from b in context.Dienst
                             where b.id == id
                             select b).FirstOrDefault();
                if (query != null)
                {
                    context.Dienst.Remove(query);
                    context.SaveChanges();
                }
            }
        }

        /// <summary>
        /// GetDienst
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Contact GetDienstid(int id)
        {
            using (var context = new Connectie())
            {
                var query = from b in context.Dienst
                            where b.id == id
                            orderby b.id
                            select b;
                var resulaat = map(query);
                return resulaat[0];
            }
        }

        /// <summary>
        /// het update van de dienst gegevens en of het toevoegen er van 
        /// </summary>
        /// <param name="Dienst"></param>
        /// <returns></returns>
        public int UpdateDienst(Contact contract)
        {
            Entity entity = map(contract);

            using (var context = new Connectie())
            {
                if (contract.id == 0)
                {
                    context.Dienst.Add(entity);
                }
                else
                {
                    var query = from b in context.Dienst
                                where b.id == contract.id
                                select b;

                    context.Entry(query.First()).CurrentValues.SetValues(entity);
                }
                context.SaveChanges();

                return context.Dienst.First().id;
            }
        }
        private Entity map(Contact contact)
        {
            return mapDienst(contact);
        }

        private List<Contact> map(IEnumerable<Entity> list)
        {
            var resultaat = new List<Contact>();
            foreach (var item in list)
            {
                var Dienst = mapDienst(item);
                resultaat.Add(Dienst);

            }
            return resultaat;
        }

        private static Entity mapDienst(Contact item)
        {
            return new Entity()
            {
                id = item.id,
                dienst = item.dienst,
                zorg = item.zorg,
                resortid = item.resortid
            };
        }

        private static Contact mapDienst(Entity item)
        {
            return new Contact()
            {
                id = item.id,
                dienst = item.dienst,
                zorg = item.zorg,
                resortid = item.resortid
            };
        }
    }
}

    
