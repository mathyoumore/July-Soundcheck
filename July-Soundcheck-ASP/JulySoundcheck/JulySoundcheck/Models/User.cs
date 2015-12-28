using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace JulySoundcheck.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class User : IdentityUser
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        [Display(Name = "Username")]
        public string DisplayName { get; set; }
        [Display(Name = "Real Name")]
        public string RealName { get; set; }
        [Display(Name = "Twitter Username")]
        public string TwitterUser { get; set; }
        public Byte[] DisplayImage { get; set; }
        public virtual List<Review> Reviews { get; set; }
        //public DbSet<User_Old> Users { get; set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<User> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class JscContext : IdentityDbContext<User>
    {
        public System.Data.Entity.DbSet<JulySoundcheck.Models.Album> Albums { get; set; }
        public System.Data.Entity.DbSet<JulySoundcheck.Models.Artist> Artists { get; set; }
        public System.Data.Entity.DbSet<JulySoundcheck.Models.Review> Reviews { get; set; }

        public JscContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<IdentityUserLogin>().HasKey<string>(l => l.UserId);
            modelBuilder.Entity<IdentityRole>().HasKey<string>(r => r.Id);
            modelBuilder.Entity<IdentityUserRole>().HasKey(r => new { r.RoleId, r.UserId });
        }

        public static JscContext Create()
        {
            return new JscContext();
        }
    }
}