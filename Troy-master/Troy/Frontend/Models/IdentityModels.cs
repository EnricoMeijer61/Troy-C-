using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Frontend.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public System.Data.Entity.DbSet<DataContract.Contract.Accomodatie> Accomodaties { get; set; }

        public System.Data.Entity.DbSet<DataContract.Contract.AccomodatieFaciliteit> AccomodatieFaciliteits { get; set; }

        public System.Data.Entity.DbSet<DataContract.Contract.Adres> Adres { get; set; }

        public System.Data.Entity.DbSet<DataContract.Contract.Dienst> Diensts { get; set; }

        public System.Data.Entity.DbSet<DataContract.Contract.Faciliteit> Faciliteits { get; set; }

        public System.Data.Entity.DbSet<DataContract.Contract.Gebruiker> Gebruikers { get; set; }

        public System.Data.Entity.DbSet<DataContract.Contract.Prijs> Prijs { get; set; }

        public System.Data.Entity.DbSet<DataContract.Contract.Reservatie> Reservaties { get; set; }

        public System.Data.Entity.DbSet<DataContract.Contract.Resort> Resorts { get; set; }

        public System.Data.Entity.DbSet<DataContract.Contract.Type> Types { get; set; }

        public System.Data.Entity.DbSet<DataContract.Contract.Uuid> Uuids { get; set; }
    }
}