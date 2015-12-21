using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace JulySoundcheck.Models
{
    public class JulySoundcheckContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public JulySoundcheckContext() : base("name=JulySoundcheckContext")
        {
        }

        public System.Data.Entity.DbSet<JulySoundcheck.Models.User> Users { get; set; }

        public System.Data.Entity.DbSet<JulySoundcheck.Models.Album> Albums { get; set; }

        public System.Data.Entity.DbSet<JulySoundcheck.Models.Artist> Artists { get; set; }

        public System.Data.Entity.DbSet<JulySoundcheck.Models.Review> Reviews { get; set; }
    }
}
