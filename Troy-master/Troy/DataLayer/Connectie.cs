using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Entity = DataLayer.Entities;

namespace DataLayer
{
    public class Connectie : DbContext
    {
        public Connectie()
            : base("name=TROY")//database connectie
        {
            // Geen automatische migratie, bestande tabellen
            Database.SetInitializer<Connectie>(null);
        }

        //Entities worden verklaard
        public DbSet<Entity.Accomodatie> Accomodatie { get; set; }
        public DbSet<Entity.AccomodatieFaciliteit> AccomodatieFaciliteit { get; set; }
        public DbSet<Entity.Adres> Adres { get; set; }
        public DbSet<Entity.Dienst> Dienst { get; set; }
        public DbSet<Entity.Faciliteit> Faciliteit { get; set; }
        public DbSet<Entity.Gebruiker> Gebruiker { get; set; }
        public DbSet<Entity.Prijs> Prijs { get; set; }
        public DbSet<Entity.Reservatie> Reservatie { get; set; }
        public DbSet<Entity.Resort> Resort { get; set; }
        public DbSet<Entity.Type> Type { get; set; }
        public DbSet<Entity.Uuid> Uuid { get; set; }

    }
}
