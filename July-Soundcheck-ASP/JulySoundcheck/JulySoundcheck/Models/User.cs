using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace JulySoundcheck.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string DisplayName { get; set; }
        public string RealName { get; set; }
        public string Email { get; set; }
        public string TwitterUser { get; set; }
        public Byte[] DisplayImage { get; set; }
        public virtual List<Review> Reviews { get; set; }
        public DbSet<User> Users { get; set; }
    }
}