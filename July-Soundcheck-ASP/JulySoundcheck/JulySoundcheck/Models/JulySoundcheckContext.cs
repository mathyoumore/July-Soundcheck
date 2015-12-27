using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace JulySoundcheck.Models
{
    public class JulySoundcheckContext : DbContext
    {    
        public JulySoundcheckContext() : base("name=JulySoundcheckContext")
        {
            Database.SetInitializer<JulySoundcheckContext>(null);
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
        }

        public static JulySoundcheckContext Create()
        {
            return new JulySoundcheckContext();
        }

        public System.Data.Entity.DbSet<JulySoundcheck.Models.Album> Albums { get; set; }

        public System.Data.Entity.DbSet<JulySoundcheck.Models.Artist> Artists { get; set; }

        public System.Data.Entity.DbSet<JulySoundcheck.Models.Review> Reviews { get; set; }
    }
}
