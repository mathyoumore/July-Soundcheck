using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace JulySoundcheck.Models
{
    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        [Display(Name = "Username")]
        public string DisplayName { get; set; }
        [Display(Name = "Real Name")]
        public string RealName { get; set; }
        [Display(Name = "Email Address")]
        public string Email { get; set; }
        [Display(Name = "Twitter Username")]
        public string TwitterUser { get; set; }
        public Byte[] DisplayImage { get; set; }
        public virtual List<Review> Reviews { get; set; }
        public DbSet<User> Users { get; set; }
    }
}