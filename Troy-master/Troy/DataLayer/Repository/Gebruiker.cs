using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Contact = DataContract.Contract.Gebruiker;
using Filter = DataContract.Filters.Gebruiker;
using Entity = DataLayer.Entities.Gebruiker;

namespace DataLayer.Repository
{
    public class Gebruiker
    {
        public List<Contact> GetGebruiker(Filter filter)
        {
            using (var connectie = new Connectie())
            {
                var query = from item in connectie.Gebruiker
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
                if (!String.IsNullOrEmpty(filter.achternaam))
                {
                    query = from item in query
                            where item.achternaam == filter.achternaam
                            select item;
                }
                if (filter.geboortedatum != null)
                {
                    query = from item in query
                            where item.geboortedatum == filter.geboortedatum
                            select item;
                }
                return map(query);
            }
        }

        /// <summary>
        /// DeleteGebruiker
        /// </summary>
        /// <param name="id"></param>
        public void DeleteGebruiker(int id)
        {
            using (var context = new Connectie())
            {
                var query = (from b in context.Gebruiker
                             where b.id == id
                             select b).FirstOrDefault();
                if (query != null)
                {
                    context.Gebruiker.Remove(query);
                    context.SaveChanges();
                }
            }
        }

        /// <summary>
        /// GetGebruiker
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Contact GetGebruikerid(int id)
        {
            using (var context = new Connectie())
            {
                var query = from b in context.Gebruiker
                            where b.id == id
                            orderby b.id
                            select b;
                var resulaat = map(query);
                return resulaat[0];
            }
        }

        /// <summary>
        /// het update van de gebruiker gegevens en of het toevoegen er van 
        /// </summary>
        /// <param name="Gebruiker"></param>
        /// <returns></returns>
        public int UpdateGebruiker(Contact contract)
        {
            Entity entity = map(contract);

            using (var context = new Connectie())
            {
                if (contract.id == 0)
                {
                    context.Gebruiker.Add(entity);
                }
                else
                {
                    var query = from b in context.Gebruiker
                                where b.id == contract.id
                                select b;

                    context.Entry(query.First()).CurrentValues.SetValues(entity);
                }
                context.SaveChanges();

                return context.Gebruiker.First().id;
            }
        }
        private Entity map(Contact contact)
        {
            return mapGebruiker(contact);
        }

        private List<Contact> map(IEnumerable<Entity> list)
        {
            var resultaat = new List<Contact>();
            foreach (var item in list)
            {
                var Gebruiker = mapGebruiker(item);
                resultaat.Add(Gebruiker);

            }
            return resultaat;
        }

        private static Entity mapGebruiker(Contact item)
        {
            return new Entity()
            {
                id = item.id,
                naam = item.naam,
                achternaam = item.achternaam,
                geboortedatum = item.geboortedatum
            };
        }

        private static Contact mapGebruiker(Entity item)
        {
            return new Contact()
            {
                id = item.id,
                naam = item.naam,
                achternaam = item.achternaam,
                geboortedatum = item.geboortedatum
            };
        }
    }
}
    
